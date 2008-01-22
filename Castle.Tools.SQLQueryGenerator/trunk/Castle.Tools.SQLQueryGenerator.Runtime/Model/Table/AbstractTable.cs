namespace Castle.Tools.SQLQueryGenerator.Runtime.Model.Table
{
	public abstract class AbstractTable : IFormatableTable
	{
		public AbstractTable(string schema, string name)
		{
			this.schema = schema;
			this.name = name;
		}

		readonly string schema;
		readonly string name;
		string alias = null;

		string IFormatableTable.Schema { get { return schema; } }
		string IFormatableTable.Name { get { return name; } }
		string IFormatableTable.Alias { get { return alias; } }

		public INonAliasedTable As(string alias)
		{
			this.alias = alias;
			return this;
		}

		public override string ToString()
		{
			return Format.Formatting.Format(this);
		}

	}
}
