using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VsroShard.Shard_Repository.Mapping
{
    public partial class TabRefTacticsMap
        : IEntityTypeConfiguration<VsroShard.Shard_Repository.Entities.TabRefTactics>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<VsroShard.Shard_Repository.Entities.TabRefTactics> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Tab_RefTactics", "dbo");

            // key
            builder.HasKey(t => t.DwTacticsID);

            // properties
            builder.Property(t => t.DwTacticsID)
                .IsRequired()
                .HasColumnName("dwTacticsID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.DwObjID)
                .HasColumnName("dwObjID")
                .HasColumnType("int");

            builder.Property(t => t.BtAIQoS)
                .HasColumnName("btAIQoS")
                .HasColumnType("tinyint");

            builder.Property(t => t.NMaxStamina)
                .IsRequired()
                .HasColumnName("nMaxStamina")
                .HasColumnType("int");

            builder.Property(t => t.BtMaxStaminaVariance)
                .HasColumnName("btMaxStaminaVariance")
                .HasColumnType("tinyint");

            builder.Property(t => t.NSightRange)
                .IsRequired()
                .HasColumnName("nSightRange")
                .HasColumnType("int");

            builder.Property(t => t.BtAggressType)
                .HasColumnName("btAggressType")
                .HasColumnType("tinyint");

            builder.Property(t => t.AggressData)
                .HasColumnName("AggressData")
                .HasColumnType("int");

            builder.Property(t => t.BtChangeTarget)
                .HasColumnName("btChangeTarget")
                .HasColumnType("tinyint");

            builder.Property(t => t.BtHelpRequestTo)
                .HasColumnName("btHelpRequestTo")
                .HasColumnType("tinyint");

            builder.Property(t => t.BtHelpResponseTo)
                .HasColumnName("btHelpResponseTo")
                .HasColumnType("tinyint");

            builder.Property(t => t.BtBattleStyle)
                .HasColumnName("btBattleStyle")
                .HasColumnType("tinyint");

            builder.Property(t => t.BattleStyleData)
                .HasColumnName("BattleStyleData")
                .HasColumnType("int");

            builder.Property(t => t.BtDiversionBasis)
                .HasColumnName("btDiversionBasis")
                .HasColumnType("tinyint");

            builder.Property(t => t.DiversionBasisData1)
                .HasColumnName("DiversionBasisData1")
                .HasColumnType("int");

            builder.Property(t => t.DiversionBasisData2)
                .HasColumnName("DiversionBasisData2")
                .HasColumnType("int");

            builder.Property(t => t.DiversionBasisData3)
                .HasColumnName("DiversionBasisData3")
                .HasColumnType("int");

            builder.Property(t => t.DiversionBasisData4)
                .HasColumnName("DiversionBasisData4")
                .HasColumnType("int");

            builder.Property(t => t.DiversionBasisData5)
                .HasColumnName("DiversionBasisData5")
                .HasColumnType("int");

            builder.Property(t => t.DiversionBasisData6)
                .HasColumnName("DiversionBasisData6")
                .HasColumnType("int");

            builder.Property(t => t.DiversionBasisData7)
                .HasColumnName("DiversionBasisData7")
                .HasColumnType("int");

            builder.Property(t => t.DiversionBasisData8)
                .HasColumnName("DiversionBasisData8")
                .HasColumnType("int");

            builder.Property(t => t.BtDiversionKeepBasis)
                .HasColumnName("btDiversionKeepBasis")
                .HasColumnType("tinyint");

            builder.Property(t => t.DiversionKeepBasisData1)
                .HasColumnName("DiversionKeepBasisData1")
                .HasColumnType("int");

            builder.Property(t => t.DiversionKeepBasisData2)
                .HasColumnName("DiversionKeepBasisData2")
                .HasColumnType("int");

            builder.Property(t => t.DiversionKeepBasisData3)
                .HasColumnName("DiversionKeepBasisData3")
                .HasColumnType("int");

            builder.Property(t => t.DiversionKeepBasisData4)
                .HasColumnName("DiversionKeepBasisData4")
                .HasColumnType("int");

            builder.Property(t => t.DiversionKeepBasisData5)
                .HasColumnName("DiversionKeepBasisData5")
                .HasColumnType("int");

            builder.Property(t => t.DiversionKeepBasisData6)
                .HasColumnName("DiversionKeepBasisData6")
                .HasColumnType("int");

            builder.Property(t => t.DiversionKeepBasisData7)
                .HasColumnName("DiversionKeepBasisData7")
                .HasColumnType("int");

            builder.Property(t => t.DiversionKeepBasisData8)
                .HasColumnName("DiversionKeepBasisData8")
                .HasColumnType("int");

            builder.Property(t => t.BtKeepDistance)
                .HasColumnName("btKeepDistance")
                .HasColumnType("tinyint");

            builder.Property(t => t.KeepDistanceData)
                .HasColumnName("KeepDistanceData")
                .HasColumnType("int");

            builder.Property(t => t.BtTraceType)
                .HasColumnName("btTraceType")
                .HasColumnType("tinyint");

            builder.Property(t => t.BtTraceBoundary)
                .HasColumnName("btTraceBoundary")
                .HasColumnType("tinyint");

            builder.Property(t => t.TraceData)
                .HasColumnName("TraceData")
                .HasColumnType("int");

            builder.Property(t => t.BtHomingType)
                .HasColumnName("btHomingType")
                .HasColumnType("tinyint");

            builder.Property(t => t.HomingData)
                .HasColumnName("HomingData")
                .HasColumnType("int");

            builder.Property(t => t.BtAggressTypeOnHoming)
                .HasColumnName("btAggressTypeOnHoming")
                .HasColumnType("tinyint");

            builder.Property(t => t.BtFleeType)
                .HasColumnName("btFleeType")
                .HasColumnType("tinyint");

            builder.Property(t => t.DwChampionTacticsID)
                .HasColumnName("dwChampionTacticsID")
                .HasColumnType("int");

            builder.Property(t => t.AdditionOptionFlag)
                .HasColumnName("AdditionOptionFlag")
                .HasColumnType("int");

            builder.Property(t => t.SzDescString128)
                .HasColumnName("szDescString128")
                .HasColumnType("varchar(129)")
                .HasMaxLength(129);

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "Tab_RefTactics";
        }

        public struct Columns
        {
            public const string DwTacticsID = "dwTacticsID";
            public const string DwObjID = "dwObjID";
            public const string BtAIQoS = "btAIQoS";
            public const string NMaxStamina = "nMaxStamina";
            public const string BtMaxStaminaVariance = "btMaxStaminaVariance";
            public const string NSightRange = "nSightRange";
            public const string BtAggressType = "btAggressType";
            public const string AggressData = "AggressData";
            public const string BtChangeTarget = "btChangeTarget";
            public const string BtHelpRequestTo = "btHelpRequestTo";
            public const string BtHelpResponseTo = "btHelpResponseTo";
            public const string BtBattleStyle = "btBattleStyle";
            public const string BattleStyleData = "BattleStyleData";
            public const string BtDiversionBasis = "btDiversionBasis";
            public const string DiversionBasisData1 = "DiversionBasisData1";
            public const string DiversionBasisData2 = "DiversionBasisData2";
            public const string DiversionBasisData3 = "DiversionBasisData3";
            public const string DiversionBasisData4 = "DiversionBasisData4";
            public const string DiversionBasisData5 = "DiversionBasisData5";
            public const string DiversionBasisData6 = "DiversionBasisData6";
            public const string DiversionBasisData7 = "DiversionBasisData7";
            public const string DiversionBasisData8 = "DiversionBasisData8";
            public const string BtDiversionKeepBasis = "btDiversionKeepBasis";
            public const string DiversionKeepBasisData1 = "DiversionKeepBasisData1";
            public const string DiversionKeepBasisData2 = "DiversionKeepBasisData2";
            public const string DiversionKeepBasisData3 = "DiversionKeepBasisData3";
            public const string DiversionKeepBasisData4 = "DiversionKeepBasisData4";
            public const string DiversionKeepBasisData5 = "DiversionKeepBasisData5";
            public const string DiversionKeepBasisData6 = "DiversionKeepBasisData6";
            public const string DiversionKeepBasisData7 = "DiversionKeepBasisData7";
            public const string DiversionKeepBasisData8 = "DiversionKeepBasisData8";
            public const string BtKeepDistance = "btKeepDistance";
            public const string KeepDistanceData = "KeepDistanceData";
            public const string BtTraceType = "btTraceType";
            public const string BtTraceBoundary = "btTraceBoundary";
            public const string TraceData = "TraceData";
            public const string BtHomingType = "btHomingType";
            public const string HomingData = "HomingData";
            public const string BtAggressTypeOnHoming = "btAggressTypeOnHoming";
            public const string BtFleeType = "btFleeType";
            public const string DwChampionTacticsID = "dwChampionTacticsID";
            public const string AdditionOptionFlag = "AdditionOptionFlag";
            public const string SzDescString128 = "szDescString128";
        }
        #endregion
    }
}
