echo off
echo Setting up environment for Qt usage...
set PATH=C:\Qt\5.7\mingw53_32\bin;C:/Qt/Tools/mingw530_32\bin;%PATH%
qmake
mingw32-make