using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class TrainingCampMemberMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.TrainingCampMember>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.TrainingCampMember> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("_TrainingCampMember", "dbo");

            // key
            builder.HasKey(t => new { t.CampID, t.CharID });

            // properties
            builder.Property(t => t.CampID)
                .IsRequired()
                .HasColumnName("CampID")
                .HasColumnType("int");

            builder.Property(t => t.CharID)
                .IsRequired()
                .HasColumnName("CharID")
                .HasColumnType("int");

            builder.Property(t => t.RefObjID)
                .IsRequired()
                .HasColumnName("RefObjID")
                .HasColumnType("int");

            builder.Property(t => t.CharName)
                .IsRequired()
                .HasColumnName("CharName")
                .HasColumnType("varchar(64)")
                .HasMaxLength(64);

            builder.Property(t => t.JoinDate)
                .IsRequired()
                .HasColumnName("JoinDate")
                .HasColumnType("smalldatetime");

            builder.Property(t => t.MemberClass)
                .IsRequired()
                .HasColumnName("MemberClass")
                .HasColumnType("tinyint");

            builder.Property(t => t.CharJoinedLevel)
                .IsRequired()
                .HasColumnName("CharJoinedLevel")
                .HasColumnType("tinyint");

            builder.Property(t => t.CharCurLevel)
                .IsRequired()
                .HasColumnName("CharCurLevel")
                .HasColumnType("tinyint");

            builder.Property(t => t.CharMaxLevel)
                .IsRequired()
                .HasColumnName("CharMaxLevel")
                .HasColumnType("tinyint");

            builder.Property(t => t.HonorPoint)
                .IsRequired()
                .HasColumnName("HonorPoint")
                .HasColumnType("int");

            // relationships
            builder.HasOne(t => t.Char)
                .WithMany(t => t.TrainingCampMembers)
                .HasForeignKey(d => d.CharID)
                .HasConstraintName("FK__TrainingCampMember__Char");

            builder.HasOne(t => t.CampTrainingCamp)
                .WithMany(t => t.CampTrainingCampMembers)
                .HasForeignKey(d => d.CampID)
                .HasConstraintName("FK__TrainingCampMember__TrainingCamp");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "_TrainingCampMember";
        }

        public struct Columns
        {
            public const string CampID = "CampID";
            public const string CharID = "CharID";
            public const string RefObjID = "RefObjID";
            public const string CharName = "CharName";
            public const string JoinDate = "JoinDate";
            public const string MemberClass = "MemberClass";
            public const string CharJoinedLevel = "CharJoinedLevel";
            public const string CharCurLevel = "CharCurLevel";
            public const string CharMaxLevel = "CharMaxLevel";
            public const string HonorPoint = "HonorPoint";
        }
        #endregion
    }
}
