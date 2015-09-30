# Introduction #
The [psqlODBC Drivers](http://pgfoundry.org/projects/psqlodbc/) for Windows are not distributed pre-built for 64-bit Windows. So we had to build them ourselves.

If you're trying to use PostgreSQL with ODBC on 64-bit Windows, this is what you need to install. ([Download](http://code.google.com/p/visionmap/downloads/list))

# Details #
  * The installer includes the required [OpenSSL](http://www.openssl.org/) binaries as well.
  * This version of psqlODBC is built with LibPQ statically linked in.