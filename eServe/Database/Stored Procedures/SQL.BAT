for %%G in (*.sql) do sqlcmd -S cs5051-sajwanih.database.windows.net -U sajwanih@cs5051-sajwanih -P "129280Eserve" -d eServe -i"%%G"
pause