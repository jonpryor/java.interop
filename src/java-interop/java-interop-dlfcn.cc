#include "java-interop.h"
#include "java-interop-dlfcn.h"
#include "java-interop-util.h"
#include "java-interop-logger.h"

#ifdef WINDOWS
#include <libloaderapi.h>
#include <winerror.h>
#include <wtypes.h>
#include <winbase.h>
#else
#include <dlfcn.h>
#include <string.h>
#endif

static char *
_get_last_dlerror ()
{
#ifdef WINDOWS

	DWORD error = GetLastError ();
	if (error == ERROR_SUCCESS /* 0 */) {
		return nullptr;
	}

	wchar_t *buf = nullptr;

	DWORD size = FormatMessageW (
			/* dwFlags */       FORMAT_MESSAGE_ALLOCATE_BUFFER | FORMAT_MESSAGE_FROM_SYSTEM | FORMAT_MESSAGE_IGNORE_INSERTS,
			/* lpSource */      NULL,
			/* dwMessageId */   error,
			/* dwLanguageId */  MAKELANGID (LANG_NEUTRAL, SUBLANG_DEFAULT),
			/* lpBuffer */      (LPWSTR) &buf,
			/* nSize */         0,
			/* Arguments */     NULL
	);
	if (size == 0)
		return nullptr;

	char *message = utf16_to_utf8 (buf);
	LocalFree (buf);

	return message;

#else   // ndef WINDOWS

	return java_interop_strdup (dlerror ());

#endif  // ndef WINDOWS
}

static void
_free_error (char **error)
{
	if (error == nullptr)
		return;
	java_interop_free (*error);
	*error = nullptr;
}

static void
_set_error (char **error, const char *message)
{
	log_warn (LOG_DEFAULT, "# jonp: _set_error: message=%s", message);
	if (error == nullptr)
		return;
	*error = java_interop_strdup (message);
}

static void
_set_error_to_last_error (char **error)
{
#if 1
	char *m = _get_last_dlerror ();
	log_warn (LOG_DEFAULT, "# jonp: _set_error_to_last_error: %s", m);
	if (error != nullptr) {
		*error = m;
		return;
	}
	free (m);
#else
	if (error == nullptr)
		return;
	*error = _get_last_dlerror ();
#endif
}

void*
java_interop_load_library (const char *path, unsigned int flags, char **error)
{
	log_warn (LOG_DEFAULT, "# jonp: java_interop_load_library: path=`%s`", path);
	_free_error (error);
	if (path == nullptr) {
		_set_error (error, "path=nullptr is not supported");
		return nullptr;
	}
#if 0
	if (flags != 0) {
		_set_error (error, "flags has unsupported value");
		return nullptr;
	}
#elif !defined (WINDOWS)
	char buf[512];
	buf[0] = '\0';
	if ((flags & RTLD_LAZY) == RTLD_LAZY)     strcat (buf, " RTLD_LAZY");
	if ((flags & RTLD_GLOBAL) == RTLD_GLOBAL) strcat (buf, " RTLD_GLOBAL");
	if ((flags & RTLD_LOCAL) == RTLD_LOCAL)   strcat (buf, " RTLD_LOCAL");
	if ((flags & RTLD_NOW) == RTLD_NOW)       strcat (buf, " RTLD_NOW");
	log_warn (LOG_DEFAULT, "# jonp: java_interop_load_library requested flags=%s; using RTLD_GLOBAL|RTLD_NOW", buf);
	flags = RTLD_GLOBAL | RTLD_NOW;
#endif

	void *handle    = nullptr;

#ifdef WINDOWS

	wchar_t *wpath   = utf8_to_utf16 (path);
	if (wpath == nullptr) {
		_set_error (error, "could not convert path to UTF-16");
		return nullptr;
	}
	HMODULE module  = LoadLibraryExW (
			/* lpLibFileName */ wpath,
			/* hFile */         nullptr,
			/* dwFlags */       LOAD_LIBRARY_SEARCH_APPLICATION_DIR | LOAD_LIBRARY_SEARCH_DLL_LOAD_DIR | LOAD_LIBRARY_SEARCH_USER_DIRS
	);
	java_interop_free (wpath);

	handle = reinterpret_cast<void*>(module);

#else   // ndef WINDOWS

	handle  = dlopen (path, flags);

#endif  // ndef WINDOWS

	if (handle == nullptr) {
		_set_error_to_last_error (error);
	}

	return handle;
}

void*
java_interop_get_symbol_address (void *library, const char *symbol, char **error)
{
	log_warn (LOG_DEFAULT, "# jonp: java_interop_get_symbol_address: library=%p symbol=%s", library, symbol);
	_free_error (error);

	if (library == nullptr) {
		_set_error (error, "library=nullptr");
		return nullptr;
	}
	if (symbol == nullptr) {
		_set_error (error, "symbol=nullptr");
		return nullptr;
	}

	void *address   = nullptr;

#ifdef WINDOWS

	HMODULE module  = reinterpret_cast<HMODULE>(library);
	FARPROC a       = GetProcAddress (module, symbol);
	address	        = reinterpret_cast<void*>(a);

#else   // ndef WINDOWS

	address         = dlsym (library, symbol);

#endif  // ndef WINDOWS

	if (address == nullptr) {
		_set_error_to_last_error (error);
	}
	log_warn (LOG_DEFAULT, "# jonp: java_interop_get_symbol_address: address=%p", address);

	return address;
}

int
java_interop_close_library (void* library, char **error)
{
	log_warn (LOG_DEFAULT, "# jonp: java_interop_close_library: library=%p", library);
	_free_error (error);
	if (library == nullptr) {
		_set_error (error, "library=nullptr");
		return JAVA_INTEROP_LIBRARY_INVALID_PARAM;
	}

	int r   = 0;

#ifdef WINDOWS
	HMODULE h   = reinterpret_cast<HMODULE>(library);
	BOOL    v   = FreeLibrary (h);
	if (!v) {
		r   = JAVA_INTEROP_LIBRARY_CLOSE_FAILED;
	}
#else   // ndef WINDOWS
	r           = dlclose (library);
	if (r != 0) {
		r   = JAVA_INTEROP_LIBRARY_CLOSE_FAILED;
	}
#endif  // ndef WINDOWS

	if (r != 0) {
		_set_error_to_last_error (error);
	}

	return r;
}
