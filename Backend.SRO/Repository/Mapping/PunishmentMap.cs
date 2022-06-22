using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroAccount.Repository.Mapping
{
    public partial class PunishmentMap
        : IEntityTypeConfiguration<VsroAccount.Repository.Entities.Punishment>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroAccount.Repository.Entities.Punishment> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_Punishment", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.SerialNo)
                .IsRequired()
                .HasColumnName("SerialNo")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.UserJID)
                .IsRequired()
                .HasColumnName("UserJID")
                .HasColumnType("int");

            builder.Property(t => t.Type)
                .IsRequired()
                .HasColumnName("Type")
                .HasColumnType("tinyint");

            builder.Property(t => t.Executor)
                .IsRequired()
                .HasColumnName("Executor")
                .HasColumnType("varchar(128)")
                .HasMaxLength(128);

            builder.Property(t => t.Shard)
                .IsRequired()
                .HasColumnName("Shard")
                .HasColumnType("smallint");

            builder.Property(t => t.CharName)
                .HasColumnName("CharName")
                .HasColumnType("varchar(64)")
                .HasMaxLength(64);

            builder.Property(t => t.CharInfo)
                .IsRequired()
                .HasColumnName("CharInfo")
                .HasColumnType("varchar(256)")
                .HasMaxLength(256);

            builder.Property(t => t.PosInfo)
                .IsRequired()
                .HasColumnName("PosInfo")
                .HasColumnType("varchar(64)")
                .HasMaxLength(64);

            builder.Property(t => t.Guide)
                .IsRequired()
                .HasColumnName("Guide")
                .HasColumnType("varchar(512)")
                .HasMaxLength(512);

            builder.Property(t => t.Description)
                .IsRequired()
                .HasColumnName("Description")
                .HasColumnType("varchar(1024)")
                .HasMaxLength(1024);

            builder.Property(t => t.RaiseTime)
                .IsRequired()
                .HasColumnName("RaiseTime")
                .HasColumnType("datetime");

            builder.Property(t => t.BlockStartTime)
                .IsRequired()
                .HasColumnName("BlockStartTime")
                .HasColumnType("datetime");

            builder.Property(t => t.BlockEndTime)
                .IsRequired()
                .HasColumnName("BlockEndTime")
                .HasColumnType("datetime");

            builder.Property(t => t.PunishTime)
                .IsRequired()
                .HasColumnName("PunishTime")
                .HasColumnType("datetime");

            builder.Property(t => t.Status)
                .IsRequired()
                .HasColumnName("Status")
                .HasColumnType("tinyint");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_Punishment";
        }

        public struct Columns
        {
            public const string SerialNo = "SerialNo";
            public const string UserJID = "UserJID";
            public const string Type = "Type";
            public const string Executor = "Executor";
            public const string Shard = "Shard";
            public const string CharName = "CharName";
            public const string CharInfo = "CharInfo";
            public const string PosInfo = "PosInfo";
            public const string Guide = "Guide";
            public const string Description = "Description";
            public const string RaiseTime = "RaiseTime";
            public const string BlockStartTime = "BlockStartTime";
            public const string BlockEndTime = "BlockEndTime";
            public const string PunishTime = "PunishTime";
            public const string Status = "Status";
        }
        #endregion
    }
}
