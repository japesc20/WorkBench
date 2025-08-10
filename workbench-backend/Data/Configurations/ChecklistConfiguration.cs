// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace backend.Data.Configurations
// {
//     public class ChecklistConfiguration
//     {
//         public void Configure(EntityTypeBuilder<Checklist> builder)
//         {
//             builder.HasKey(c => c.Id);

//             builder.Property(c => c.Name)
//                 .IsRequired()
//                 .HasMaxLength(100);

//             builder.HasMany(c => c.Items)
//                 .WithOne(i => i.Checklist)
//                 .HasForeignKey(i => i.ChecklistId);
//         }
//     }
// }