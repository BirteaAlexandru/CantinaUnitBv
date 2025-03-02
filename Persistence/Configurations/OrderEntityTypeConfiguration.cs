﻿using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    internal class OrderEntityTypeConfiguration : BasicEntityTypeConfiguration<Order>
    {
        protected override void ConfigureEntity(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Order");

            builder.Property(p => p.UserId)
               .HasColumnName("UserId")
               .IsRequired();

            builder.HasOne(s => s.User)
            .WithMany(g => g.Orders)
            .HasForeignKey(s => s.UserId);
        }
    }
}
