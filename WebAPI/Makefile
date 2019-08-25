DOTNET = dotnet

remake_database: nuke_database make_database

nuke_database:
	$(DOTNET) restore
	$(DOTNET) ef database drop -f

make_database:
	$(DOTNET) restore
	$(DOTNET) ef database update
