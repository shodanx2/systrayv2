path=%path%;c:\windows\microsoft.net\framework\v4.0.30319
cd res
resgen Res.resx 
cd ..
VBC /OUT:app.exe /resource:res\Res.resources /T:exe *.vb res\Res.vb lib\*.vb
pause

