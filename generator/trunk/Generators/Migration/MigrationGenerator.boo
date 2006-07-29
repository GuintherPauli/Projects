import System.IO

class MigrationGenerator(NamedGeneratorBase):
	def Run():
		sVersion = string.Format("{0:000}", Version)
		Process('Migration.cs', "${MigrationsBasePath}/${sVersion}_${ClassName}.cs")
	
	def Help() as string:
		return 'Generates a migration'

	Version as int:
		get:
			return LastVersion+1

	LastVersion as int:
		get:
			max = 1
			for file in Directory.GetFiles("${MigrationsBasePath}"):
				info = FileInfo(file)
				if info.Name.Substring(3, 1) == '_':
					v = int.Parse(info.Name.Substring(0, 3))
					max = v if v > max
			return max
			
	Namespace:
		get:
			return MigrationsNamespace
