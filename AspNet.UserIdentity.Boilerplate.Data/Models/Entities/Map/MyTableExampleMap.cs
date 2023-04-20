using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AspNet.UserIdentity.Boilerplate.Data.Models.Entities.Map
{
	public static class MyTableExampleMap
	{

		public static void Map(this EntityTypeBuilder<MyTableExample> entityTypeBuilder)
		{

			entityTypeBuilder.ToTable("MyTableExampleName");

			entityTypeBuilder.HasKey(p => p.TableID);
			entityTypeBuilder.Property(p => p.TableID).ValueGeneratedOnAdd();

		}
	}
}
