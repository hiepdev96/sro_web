using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroAccount.Repository.Mapping
{
    public partial class TBUserMap
        : IEntityTypeConfiguration<VsroAccount.Repository.Entities.TBUser>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroAccount.Repository.Entities.TBUser> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("TB_User", "dbo");

            // key
            builder.HasKey(t => t.Jid);

            // properties
            builder.Property(t => t.Jid)
                .IsRequired()
                .HasColumnName("JID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.StrUserID)
                .IsRequired()
                .HasColumnName("StrUserID")
                .HasColumnType("varchar(25)")
                .HasMaxLength(25);

            builder.Property(t => t.Password)
                .IsRequired()
                .HasColumnName("password")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Status)
                .HasColumnName("Status")
                .HasColumnType("tinyint");

            builder.Property(t => t.GMrank)
                .HasColumnName("GMrank")
                .HasColumnType("tinyint");

            builder.Property(t => t.Name)
                .HasColumnName("Name")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Email)
                .HasColumnName("Email")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Sex)
                .HasColumnName("sex")
                .HasColumnType("char(2)")
                .HasMaxLength(2);

            builder.Property(t => t.CertificateNum)
                .HasColumnName("certificate_num")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(t => t.Address)
                .HasColumnName("address")
                .HasColumnType("nvarchar(100)")
                .HasMaxLength(100);

            builder.Property(t => t.Postcode)
                .HasColumnName("postcode")
                .HasColumnType("varchar(10)")
                .HasMaxLength(10);

            builder.Property(t => t.Phone)
                .HasColumnName("phone")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.Mobile)
                .HasColumnName("mobile")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.Regtime)
                .HasColumnName("regtime")
                .HasColumnType("datetime");

            builder.Property(t => t.RegIp)
                .HasColumnName("reg_ip")
                .HasColumnType("varchar(25)")
                .HasMaxLength(25);

            builder.Property(t => t.TimeLog)
                .HasColumnName("Time_log")
                .HasColumnType("datetime");

            builder.Property(t => t.Freetime)
                .HasColumnName("freetime")
                .HasColumnType("int");

            builder.Property(t => t.SecPrimary)
                .IsRequired()
                .HasColumnName("sec_primary")
                .HasColumnType("tinyint")
                .HasDefaultValueSql("((3))");

            builder.Property(t => t.SecContent)
                .IsRequired()
                .HasColumnName("sec_content")
                .HasColumnType("tinyint")
                .HasDefaultValueSql("((3))");

            builder.Property(t => t.AccPlayTime)
                .IsRequired()
                .HasColumnName("AccPlayTime")
                .HasColumnType("int");

            builder.Property(t => t.LatestUpdateTimeToPlayTime)
                .IsRequired()
                .HasColumnName("LatestUpdateTime_ToPlayTime")
                .HasColumnType("int");

            builder.Property(t => t.Play123Time)
                .IsRequired()
                .HasColumnName("Play123Time")
                .HasColumnType("int");

            builder.Property(t => t.Password2)
                .HasColumnName("password2")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "TB_User";
        }

        public struct Columns
        {
            public const string Jid = "JID";
            public const string StrUserID = "StrUserID";
            public const string Password = "password";
            public const string Status = "Status";
            public const string GMrank = "GMrank";
            public const string Name = "Name";
            public const string Email = "Email";
            public const string Sex = "sex";
            public const string CertificateNum = "certificate_num";
            public const string Address = "address";
            public const string Postcode = "postcode";
            public const string Phone = "phone";
            public const string Mobile = "mobile";
            public const string Regtime = "regtime";
            public const string RegIp = "reg_ip";
            public const string TimeLog = "Time_log";
            public const string Freetime = "freetime";
            public const string SecPrimary = "sec_primary";
            public const string SecContent = "sec_content";
            public const string AccPlayTime = "AccPlayTime";
            public const string LatestUpdateTimeToPlayTime = "LatestUpdateTime_ToPlayTime";
            public const string Play123Time = "Play123Time";
            public const string Password2 = "password2";
        }
        #endregion
    }
}
