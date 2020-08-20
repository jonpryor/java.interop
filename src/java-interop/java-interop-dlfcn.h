#ifndef INC_JAVA_INTEROP_DLFCN_H
#define INC_JAVA_INTEROP_DLFCN_H

#include "java-interop.h"

JAVA_INTEROP_BEGIN_DECLS

// Possible error codes from java_interop_close_library
constexpr   int JAVA_INTEROP_LIBRARY_FAILED         = -1000;
constexpr   int JAVA_INTEROP_LIBRARY_CLOSE_FAILED   = JAVA_INTEROP_LIBRARY_FAILED-1;
constexpr   int JAVA_INTEROP_LIBRARY_INVALID_PARAM  = JAVA_INTEROP_LIBRARY_FAILED-2;


JAVA_INTEROP_API    void*   java_interop_load_library (const char *path, unsigned int flags, char **error);
JAVA_INTEROP_API    void*   java_interop_get_symbol_address (void* library, const char *symbol, char **error);
JAVA_INTEROP_API    int     java_interop_close_library (void* library, char **error);

JAVA_INTEROP_END_DECLS

#endif /* INC_JAVA_INTEROP_DLFCN_H */
