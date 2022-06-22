using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroAccount.Repository.Mapping
{
    public partial class TBNet2eMap
        : IEntityTypeConfiguration<VsroAccount.Repository.Entities.TBNet2e>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroAccount.Repository.Entities.TBNet2e> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("TB_Net2e", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.Jid)
                .IsRequired()
                .HasColumnName("JID")
                .HasColumnType("int");

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

            builder.Property(t => t.SecondPassword)
                .HasColumnName("SecondPassword")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Question)
                .HasColumnName("question")
                .HasColumnType("nvarchar(70)")
                .HasMaxLength(70);

            builder.Property(t => t.Answer)
                .HasColumnName("answer")
                .HasColumnType("nvarchar(50)")
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

            builder.Property(t => t.Mdk)
                .HasColumnName("MDK")
                .HasColumnType("varchar(50)")
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

            builder.Property(t => t.Cid)
                .HasColumnName("cid")
                .HasColumnType("nvarchar(70)")
                .HasMaxLength(70);

            builder.Property(t => t.CidType)
                .HasColumnName("cidType")
                .HasColumnType("int");

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
                .HasColumnType("tinyint");

            builder.Property(t => t.SecContent)
                .IsRequired()
                .HasColumnName("sec_content")
                .HasColumnType("tinyint");

            builder.Property(t => t.Birthday)
                .HasColumnName("Birthday")
                .HasColumnType("datetime");

            builder.Property(t => t.Province)
                .HasColumnName("Province")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.District)
                .HasColumnName("District")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.WherePlay)
                .HasColumnName("WherePlay")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.WhereKnow)
                .HasColumnName("WhereKnow")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Reference)
                .HasColumnName("Reference")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Games)
                .HasColumnName("Games")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.StrLevel)
                .HasColumnName("strLevel")
                .HasColumnType("varchar(10)")
                .HasMaxLength(10);

            builder.Property(t => t.Class)
                .HasColumnName("Class")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.HowPlay)
                .HasColumnName("HowPlay")
                .HasColumnType("tinyint");

            builder.Property(t => t.Inviter)
                .HasColumnName("Inviter")
                .HasColumnType("varchar(25)")
                .HasMaxLength(25);

            builder.Property(t => t.SecAct)
                .HasColumnName("Sec_act")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.LastModification)
                .HasColumnName("LastModification")
                .HasColumnType("datetime");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "TB_Net2e";
        }

        public struct Columns
        {
            public const string Jid = "JID";
            public const string StrUserID = "StrUserID";
            public const string Password = "password";
            public const string SecondPassword = "SecondPassword";
            public const string Question = "question";
            public const string Answer = "answer";
            public const string Status = "Status";
            public const string GMrank = "GMrank";
            public const string Name = "Name";
            public const string Mdk = "MDK";
            public const string Email = "Email";
            public const string Sex = "sex";
            public const string CertificateNum = "certificate_num";
            public const string Address = "address";
            public const string Postcode = "postcode";
            public const string Phone = "phone";
            public const string Mobile = "mobile";
            public const string Cid = "cid";
            public const string CidType = "cidType";
            public const string Regtime = "regtime";
            public const string RegIp = "reg_ip";
            public const string TimeLog = "Time_log";
            public const string Freetime = "freetime";
            public const string SecPrimary = "sec_primary";
            public const string SecContent = "sec_content";
            public const string Birthday = "Birthday";
            public const string Province = "Province";
            public const string District = "District";
            public const string WherePlay = "WherePlay";
            public const string WhereKnow = "WhereKnow";
            public const string Reference = "Reference";
            public const string Games = "Games";
            public const string StrLevel = "strLevel";
            public const string Class = "Class";
            public const string HowPlay = "HowPlay";
            public const string Inviter = "Inviter";
            public const string SecAct = "Sec_act";
            public const string LastModification = "LastModification";
        }
        #endregion
    }
}
