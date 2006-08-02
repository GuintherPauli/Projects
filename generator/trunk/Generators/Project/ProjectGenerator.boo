import System.IO

class ProjectGenerator(NamedGeneratorBase):
	def Run():
		MkDir(Name)
		
		MkDir("${Name}/app/controllers")
		Process("app/controllers/ApplicationController.cs", "${Name}/app/controllers/ApplicationController.cs")
		MkDir("${Name}/app/helpers")
		MkDir("${Name}/app/models")
		MkDir("${Name}/app/views")
		MkDir("${Name}/app/views/layouts")
		MkDir("${Name}/app/views/rescues")
		
		MkDir("${Name}/config")
		Process("config/Boot.cs", "${Name}/config/Boot.cs")
		MkDir("${Name}/config/databases")
		Process("config/databases/development.xml", "${Name}/config/databases/development.xml")
		Process("config/databases/test.xml", "${Name}/config/databases/test.xml")
		
		Process("default.build", "${Name}/default.build")
		
		MkDir("${Name}/doc")
		Process("doc/readme.txt", "${Name}/doc/readme.txt")
		
		CopyDir("lib", "${Name}/lib")
		CopyDir("../../../bin", "${Name}/lib/generator/bin")
		CopyDir("../../../Generators", "${Name}/lib/generator/Generators")
		FileInfo("${Name}/lib/generator/Generators/Config.boo").Delete()
		Process("Config.boo", "${Name}/lib/generator/Generators/Config.boo")
		
		MkDir("${Name}/log")

		MkDir("${Name}/db")
		MkDir("${Name}/db/migrations")
		
		MkDir("${Name}/public/content")
		CopyDir("public/content", "${Name}/public/content")
		Process("public/global.asax", "${Name}/public/global.asax")
		Process("public/index.html", "${Name}/public/index.html")
		Process("public/web.config", "${Name}/public/web.config")
		
		MkDir("${Name}/script")
		Process("script/console.boo", "${Name}/script/console.boo")
		Copy("script/console", "${Name}/script")
		Copy("script/console.bat", "${Name}/script")
		Copy("script/generate", "${Name}/script")
		Copy("script/generate.bat", "${Name}/script")
		Copy("script/server", "${Name}/script")
		Copy("script/server.bat", "${Name}/script")
		
		MkDir("${Name}/test/controllers")
		Process("test/controllers/ControllerTestCase.cs", "${Name}/test/controllers/ControllerTestCase.cs")
		MkDir("${Name}/test/helpers")
		MkDir("${Name}/test/models")
		Process("test/models/ActiveRecordTestCase.cs", "${Name}/test/models/ActiveRecordTestCase.cs")
		
		print "Run 'nant setup' from the base directory to setup the environment"
	
	def Help():
		return 'Generates a new MonoRail project'
		
	def Usage():
		return "ProjectName"
