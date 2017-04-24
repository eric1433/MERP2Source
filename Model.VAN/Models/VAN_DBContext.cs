using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Model.VAN.Models
{
    public partial class VAN_DBContext : DbContext
    {
        private readonly string _connectionString;

        public VAN_DBContext(string connectionString)
        {
            this._connectionString = connectionString;
        }

        public virtual DbSet<ACTBAL> ACTBAL { get; set; }
        public virtual DbSet<ACTNO> ACTNO { get; set; }
        public virtual DbSet<ACTNOCAL> ACTNOCAL { get; set; }
        public virtual DbSet<ACTNOLEV> ACTNOLEV { get; set; }
        public virtual DbSet<ACTRPTDL> ACTRPTDL { get; set; }
        public virtual DbSet<ACTRPTMT> ACTRPTMT { get; set; }
        public virtual DbSet<ACTVCHCOPY> ACTVCHCOPY { get; set; }
        public virtual DbSet<ACTVCHDL> ACTVCHDL { get; set; }
        public virtual DbSet<ACTVCHMT> ACTVCHMT { get; set; }
        public virtual DbSet<AJSVCHDL> AJSVCHDL { get; set; }
        public virtual DbSet<ATTRDL> ATTRDL { get; set; }
        public virtual DbSet<ATTRMT> ATTRMT { get; set; }
        public virtual DbSet<BANK> BANK { get; set; }
        public virtual DbSet<BANKING> BANKING { get; set; }
        public virtual DbSet<CITEM> CITEM { get; set; }
        public virtual DbSet<CONTR> CONTR { get; set; }
        public virtual DbSet<CONTRBUG> CONTRBUG { get; set; }
        public virtual DbSet<CONTRCITEM> CONTRCITEM { get; set; }
        public virtual DbSet<CONTRCITEMAR> CONTRCITEMAR { get; set; }
        public virtual DbSet<CONTRMT> CONTRMT { get; set; }
        public virtual DbSet<CORP> CORP { get; set; }
        public virtual DbSet<CPADDDL> CPADDDL { get; set; }
        public virtual DbSet<CPADDMT> CPADDMT { get; set; }
        public virtual DbSet<CTARACT> CTARACT { get; set; }
        public virtual DbSet<CTARDL> CTARDL { get; set; }
        public virtual DbSet<CTARMT> CTARMT { get; set; }
        public virtual DbSet<CTARPACT> CTARPACT { get; set; }
        public virtual DbSet<CTDRACT> CTDRACT { get; set; }
        public virtual DbSet<CTDRAR> CTDRAR { get; set; }
        public virtual DbSet<CTDRDL> CTDRDL { get; set; }
        public virtual DbSet<CTDRMT> CTDRMT { get; set; }
        public virtual DbSet<CTPRACT> CTPRACT { get; set; }
        public virtual DbSet<CTPRDL> CTPRDL { get; set; }
        public virtual DbSet<CTPRMT> CTPRMT { get; set; }
        public virtual DbSet<CTRARACT> CTRARACT { get; set; }
        public virtual DbSet<CTRARDL> CTRARDL { get; set; }
        public virtual DbSet<CTRARML> CTRARML { get; set; }
        public virtual DbSet<CTRARMT> CTRARMT { get; set; }
        public virtual DbSet<CTRARNOTR> CTRARNOTR { get; set; }
        public virtual DbSet<CUSTOMER> CUSTOMER { get; set; }
        public virtual DbSet<DEPM> DEPM { get; set; }
        public virtual DbSet<DEPMCAL> DEPMCAL { get; set; }
        public virtual DbSet<DEPMLEV> DEPMLEV { get; set; }
        public virtual DbSet<EIPFRL> EIPFRL { get; set; }
        public virtual DbSet<EIPWRK> EIPWRK { get; set; }
        public virtual DbSet<EMPALW> EMPALW { get; set; }
        public virtual DbSet<EMPCORP> EMPCORP { get; set; }
        public virtual DbSet<EMPDRAW> EMPDRAW { get; set; }
        public virtual DbSet<EMPEQUIP> EMPEQUIP { get; set; }
        public virtual DbSet<EMPEXAM> EMPEXAM { get; set; }
        public virtual DbSet<EMPFM> EMPFM { get; set; }
        public virtual DbSet<EMPFMCHG> EMPFMCHG { get; set; }
        public virtual DbSet<EMPFRL> EMPFRL { get; set; }
        public virtual DbSet<EMPIJT> EMPIJT { get; set; }
        public virtual DbSet<EMPIMG> EMPIMG { get; set; }
        public virtual DbSet<EMPISU> EMPISU { get; set; }
        public virtual DbSet<EMPISUCHG> EMPISUCHG { get; set; }
        public virtual DbSet<EMPLOYEE> EMPLOYEE { get; set; }
        public virtual DbSet<EMPPAYACT> EMPPAYACT { get; set; }
        public virtual DbSet<EMPPAYACT_LOG> EMPPAYACT_LOG { get; set; }
        public virtual DbSet<EMPPAYAJS> EMPPAYAJS { get; set; }
        public virtual DbSet<EMPPAYAJS_LOG> EMPPAYAJS_LOG { get; set; }
        public virtual DbSet<EMPPAYDL> EMPPAYDL { get; set; }
        public virtual DbSet<EMPPAYDL_LOG> EMPPAYDL_LOG { get; set; }
        public virtual DbSet<EMPPAYDPC> EMPPAYDPC { get; set; }
        public virtual DbSet<EMPPAYDPC_LOG> EMPPAYDPC_LOG { get; set; }
        public virtual DbSet<EMPPAYDRAW> EMPPAYDRAW { get; set; }
        public virtual DbSet<EMPPAYDRAW_LOG> EMPPAYDRAW_LOG { get; set; }
        public virtual DbSet<EMPPAYEQUIP> EMPPAYEQUIP { get; set; }
        public virtual DbSet<EMPPAYEQUIP_LOG> EMPPAYEQUIP_LOG { get; set; }
        public virtual DbSet<EMPPAYFM> EMPPAYFM { get; set; }
        public virtual DbSet<EMPPAYFM_LOG> EMPPAYFM_LOG { get; set; }
        public virtual DbSet<EMPPAYFRL> EMPPAYFRL { get; set; }
        public virtual DbSet<EMPPAYFRL_LOG> EMPPAYFRL_LOG { get; set; }
        public virtual DbSet<EMPPAYIJT> EMPPAYIJT { get; set; }
        public virtual DbSet<EMPPAYIJT_LOG> EMPPAYIJT_LOG { get; set; }
        public virtual DbSet<EMPPAYISU> EMPPAYISU { get; set; }
        public virtual DbSet<EMPPAYISU_LOG> EMPPAYISU_LOG { get; set; }
        public virtual DbSet<EMPPAYMT> EMPPAYMT { get; set; }
        public virtual DbSet<EMPPAYMT_LOG> EMPPAYMT_LOG { get; set; }
        public virtual DbSet<EMPPAYOTH> EMPPAYOTH { get; set; }
        public virtual DbSet<EMPPAYOTH_LOG> EMPPAYOTH_LOG { get; set; }
        public virtual DbSet<EMPPAYWRK> EMPPAYWRK { get; set; }
        public virtual DbSet<EMPPAYWRK_LOG> EMPPAYWRK_LOG { get; set; }
        public virtual DbSet<EMPPMS> EMPPMS { get; set; }
        public virtual DbSet<EMPWRK> EMPWRK { get; set; }
        public virtual DbSet<EQUIP> EQUIP { get; set; }
        public virtual DbSet<ErrorLog> ErrorLog { get; set; }
        public virtual DbSet<FILEDL> FILEDL { get; set; }
        public virtual DbSet<FILEMT> FILEMT { get; set; }
        public virtual DbSet<FRLNO> FRLNO { get; set; }
        public virtual DbSet<GNRLGR> GNRLGR { get; set; }
        public virtual DbSet<GRPNO> GRPNO { get; set; }
        public virtual DbSet<GRPPMS> GRPPMS { get; set; }
        public virtual DbSet<ISUADD> ISUADD { get; set; }
        public virtual DbSet<ISUGRD> ISUGRD { get; set; }
        public virtual DbSet<ISUID> ISUID { get; set; }
        public virtual DbSet<IVCCNAR> IVCCNAR { get; set; }
        public virtual DbSet<IVCCNDL> IVCCNDL { get; set; }
        public virtual DbSet<IVCCNMT> IVCCNMT { get; set; }
        public virtual DbSet<IVCGRP> IVCGRP { get; set; }
        public virtual DbSet<IVCMM> IVCMM { get; set; }
        public virtual DbSet<IVCMMDEPM> IVCMMDEPM { get; set; }
        public virtual DbSet<IVCMMUSR> IVCMMUSR { get; set; }
        public virtual DbSet<IVCMMVCH> IVCMMVCH { get; set; }
        public virtual DbSet<JOB> JOB { get; set; }
        public virtual DbSet<MDMBANK> MDMBANK { get; set; }
        public virtual DbSet<MENU> MENU { get; set; }
        public virtual DbSet<PAYYMCFG> PAYYMCFG { get; set; }
        public virtual DbSet<PMSETRDL> PMSETRDL { get; set; }
        public virtual DbSet<PMSNAME> PMSNAME { get; set; }
        public virtual DbSet<PMSNO> PMSNO { get; set; }
        public virtual DbSet<PNLCFG> PNLCFG { get; set; }
        public virtual DbSet<PRGNO> PRGNO { get; set; }
        public virtual DbSet<REWARD> REWARD { get; set; }
        public virtual DbSet<RWDPAY> RWDPAY { get; set; }
        public virtual DbSet<SERJOB> SERJOB { get; set; }
        public virtual DbSet<SERLEV> SERLEV { get; set; }
        public virtual DbSet<SERVE> SERVE { get; set; }
        public virtual DbSet<SLVDL> SLVDL { get; set; }
        public virtual DbSet<SLVISU> SLVISU { get; set; }
        public virtual DbSet<SLVMT> SLVMT { get; set; }
        public virtual DbSet<SLYTRACT> SLYTRACT { get; set; }
        public virtual DbSet<SLYTRDL> SLYTRDL { get; set; }
        public virtual DbSet<SLYTRMT> SLYTRMT { get; set; }
        public virtual DbSet<SYSCONFG> SYSCONFG { get; set; }
        public virtual DbSet<SYSNO> SYSNO { get; set; }
        public virtual DbSet<TITLE> TITLE { get; set; }
        public virtual DbSet<USRARDEPM> USRARDEPM { get; set; }
        public virtual DbSet<USRGRP> USRGRP { get; set; }
        public virtual DbSet<USRIVCDEPM> USRIVCDEPM { get; set; }
        public virtual DbSet<USRNO> USRNO { get; set; }
        public virtual DbSet<USRPMS> USRPMS { get; set; }
        public virtual DbSet<USRRARDEPM> USRRARDEPM { get; set; }
        public virtual DbSet<VCHCFMLG> VCHCFMLG { get; set; }
        public virtual DbSet<VCHCONFG> VCHCONFG { get; set; }
        public virtual DbSet<VCHUSR> VCHUSR { get; set; }
        public virtual DbSet<VENDOR> VENDOR { get; set; }
        public virtual DbSet<VITEM> VITEM { get; set; }
        public virtual DbSet<vw_System_Program_Menu> vw_System_Program_Menu { get; set; }

        // Unable to generate entity type for table 'dbo.pbcatvld'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.pbcatedt'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TMP_EQUIP'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SYSBLOB'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.EMP_WRK_TMP'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TMP_NEWCITY'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.pbcattbl'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.pbcatcol'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.pbcatfmt'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
            //optionsBuilder.UseSqlServer(@"Server=.\sqlserver2012;Database=VAN_DB;user id=sa;password=mssql;");
            optionsBuilder.UseSqlServer(this._connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ACTBAL>(entity =>
            {
                entity.HasIndex(e => new { e.CORP_NO, e.YYYY, e.ACT_NO })
                    .HasName("ACTBAL_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ACT_NO)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.CORP_NO)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CR_AMT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DR_AMT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.YYYY).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ACTNO>(entity =>
            {
                entity.HasIndex(e => e.ACT_NO)
                    .HasName("ACTNO_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ACT_NM)
                    .HasMaxLength(80)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ACT_NO)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CURRENCY)
                    .HasMaxLength(4)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_BCH)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_BCH_SOURCE)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_CLAS)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_CTRL)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_CURRENCY)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_DCR).HasDefaultValueSql("0");

                entity.Property(e => e.C_DEPM)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_LEV).HasDefaultValueSql("0");

                entity.Property(e => e.ENG_NM)
                    .HasMaxLength(80)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.EXCH_RT_TY)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MGT_CODE)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.S_DEPM)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.U_ACT_NO)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<ACTNOCAL>(entity =>
            {
                entity.HasIndex(e => new { e.ACT_NO, e.D_ACT_NO })
                    .HasName("ACTNOCAL_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ACT_NO)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.D_ACT_NO)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<ACTNOLEV>(entity =>
            {
                entity.HasIndex(e => new { e.ACT_NO, e.D_ACT_NO })
                    .HasName("ACTNOLEV_X1");

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ACT_NO)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_SOURCE)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.D_ACT_NO)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<ACTRPTDL>(entity =>
            {
                entity.HasIndex(e => new { e.PID, e.ID })
                    .HasName("ACTRPTDL_X9")
                    .IsUnique();

                entity.HasIndex(e => new { e.RPT_NO, e.RPT_SR })
                    .HasName("ACTRPTDL_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ACT_NM)
                    .HasMaxLength(80)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ACT_NO)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_DCR).HasDefaultValueSql("1");

                entity.Property(e => e.C_DISP)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_DNN)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_POSI)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_SOURCE)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_ZERO)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ROW_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RPT_NO)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RPT_SR).HasDefaultValueSql("0");

                entity.HasOne(d => d.P)
                    .WithMany(p => p.ACTRPTDL)
                    .HasForeignKey(d => d.PID)
                    .HasConstraintName("FK_ACTRPTDL_ACTRPTMT");
            });

            modelBuilder.Entity<ACTRPTMT>(entity =>
            {
                entity.HasIndex(e => e.RPT_NO)
                    .HasName("ACTRPTMT")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PRT_TY)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RPT_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RPT_NO)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RPT_TY)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SIGN)
                    .HasMaxLength(180)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<ACTVCHCOPY>(entity =>
            {
                entity.HasIndex(e => new { e.COPY_NO, e.VCH_SR })
                    .HasName("ACTVCHCOPY_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ACT_NO)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.AMT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BCH_NO)
                    .HasMaxLength(24)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CFW_NO)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CN_NO)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.COPY_NO)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CS_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_DCR).HasDefaultValueSql("1");

                entity.Property(e => e.DEPM_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.EMP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PRJ_NO)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.REMK)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SER_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SVCH_NO)
                    .HasMaxLength(15)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SVCH_SR).HasDefaultValueSql("0");

                entity.Property(e => e.SVCH_TY)
                    .HasMaxLength(4)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.VCH_SR).HasDefaultValueSql("0");

                entity.Property(e => e.VD_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<ACTVCHDL>(entity =>
            {
                entity.HasIndex(e => new { e.PID, e.ID })
                    .HasName("ACTVCHDL_X9")
                    .IsUnique();

                entity.HasIndex(e => new { e.VCH_TY, e.VCH_NO, e.VCH_SR })
                    .HasName("ACTVCHDL_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ACT_NO)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.AMT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BCH_NO)
                    .HasMaxLength(24)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CFW_NO)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CN_NO)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CS_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_DCR).HasDefaultValueSql("1");

                entity.Property(e => e.DEPM_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.EMP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PID).HasDefaultValueSql("newid()");

                entity.Property(e => e.PRJ_NO)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.REMK)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SER_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SVCH_NO)
                    .HasMaxLength(15)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SVCH_SR).HasDefaultValueSql("0");

                entity.Property(e => e.SVCH_TY)
                    .HasMaxLength(4)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.VCH_NO)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.VCH_SR).HasDefaultValueSql("0");

                entity.Property(e => e.VCH_TY)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.VD_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.HasOne(d => d.P)
                    .WithMany(p => p.ACTVCHDL)
                    .HasForeignKey(d => d.PID)
                    .HasConstraintName("FK_ACTVCHDL_ACTVCHMT");
            });

            modelBuilder.Entity<ACTVCHMT>(entity =>
            {
                entity.HasIndex(e => new { e.VCH_TY, e.VCH_NO })
                    .HasName("ACTVCHMT_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.CFM_DT).HasColumnType("datetime");

                entity.Property(e => e.CFM_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CORP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_CFM)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_SIGN)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_SOURCE).HasMaxLength(1);

                entity.Property(e => e.EMP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.N_PRT).HasDefaultValueSql("0");

                entity.Property(e => e.OVCH_NO)
                    .HasMaxLength(15)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OVCH_TY)
                    .HasMaxLength(4)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.REMK)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SVCH_NO)
                    .HasMaxLength(15)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SVCH_TY)
                    .HasMaxLength(4)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.VCH_DT).HasColumnType("datetime");

                entity.Property(e => e.VCH_NO)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.VCH_TY)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<AJSVCHDL>(entity =>
            {
                entity.HasIndex(e => new { e.AVCH_TY, e.AVCH_NO })
                    .HasName("AJSVCHDL_X2");

                entity.HasIndex(e => new { e.VCH_TY, e.VCH_NO, e.C_SOURCE })
                    .HasName("AJSVCHDL_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.AJS_DT).HasColumnType("datetime");

                entity.Property(e => e.AJS_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.AVCH_DT).HasColumnType("datetime");

                entity.Property(e => e.AVCH_NO)
                    .HasMaxLength(15)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.AVCH_TY)
                    .HasMaxLength(4)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_SOURCE)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.VCH_DT).HasColumnType("datetime");

                entity.Property(e => e.VCH_NO)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.VCH_TY)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<ATTRDL>(entity =>
            {
                entity.HasIndex(e => new { e.ATTR_TY, e.ATTR_NO })
                    .HasName("ATTRDL_X1")
                    .IsUnique();

                entity.HasIndex(e => new { e.ID, e.PID })
                    .HasName("ATTRDL_X9")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.ATTR_NM).HasMaxLength(20);

                entity.Property(e => e.ATTR_NO)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.ATTR_SR).HasMaxLength(10);

                entity.Property(e => e.ATTR_TY)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.CP_NM).HasMaxLength(30);

                entity.Property(e => e.C_SOURCE).HasMaxLength(1);

                entity.Property(e => e.C_STA).HasMaxLength(1);

                entity.Property(e => e.C_TY).HasMaxLength(1);

                entity.Property(e => e.IP_NM).HasMaxLength(30);

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO).HasMaxLength(10);

                entity.Property(e => e.OWNER_GRP_NO).HasMaxLength(10);

                entity.Property(e => e.OWNER_USR_NO).HasMaxLength(10);

                entity.Property(e => e.PRG_NO).HasMaxLength(24);

                entity.Property(e => e.REMK).HasMaxLength(255);

                entity.Property(e => e.TABLE_NM).HasMaxLength(30);

                entity.HasOne(d => d.P)
                    .WithMany(p => p.ATTRDL)
                    .HasForeignKey(d => d.PID)
                    .HasConstraintName("FK_ATTRDL_ATTRMT");
            });

            modelBuilder.Entity<ATTRMT>(entity =>
            {
                entity.HasIndex(e => e.ATTR_TY)
                    .HasName("ATTRMT_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.ATTR_NM).HasMaxLength(20);

                entity.Property(e => e.ATTR_TY)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.CP_NM).HasMaxLength(30);

                entity.Property(e => e.C_SOURCE).HasMaxLength(1);

                entity.Property(e => e.IP_NM).HasMaxLength(30);

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO).HasMaxLength(10);

                entity.Property(e => e.OWNER_GRP_NO).HasMaxLength(10);

                entity.Property(e => e.OWNER_USR_NO).HasMaxLength(10);

                entity.Property(e => e.REMK).HasMaxLength(255);
            });

            modelBuilder.Entity<BANK>(entity =>
            {
                entity.HasIndex(e => e.BANK_NO)
                    .HasName("BANK_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ACC_NO)
                    .HasMaxLength(80)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ACT_NO)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ADDR)
                    .HasMaxLength(80)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ADDR2)
                    .HasMaxLength(80)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ADDR2_E)
                    .HasMaxLength(80)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ADDR_E)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.AMT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BANK_ID)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.BANK_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.BANK_NM_E)
                    .HasMaxLength(80)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.BANK_NO)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.BCH_NO)
                    .HasMaxLength(24)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CONTACTER)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CONTACTER2)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CONTACTER3)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CURRENCY)
                    .HasMaxLength(4)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.DPS_KD)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.E_MAIL)
                    .HasMaxLength(80)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.FAX_NO)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.FULL_NM)
                    .HasMaxLength(80)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.FULL_NM_E)
                    .HasMaxLength(80)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.NP_ACT_NO)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.NP_BCH_NO)
                    .HasMaxLength(24)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.NR_ACT_NO)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.NR_BCH_NO)
                    .HasMaxLength(24)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.NT_AMT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.REMK)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TEL_NO)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TEL_NO2)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TEL_NO3)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.WWW)
                    .HasMaxLength(80)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<BANKING>(entity =>
            {
                entity.HasIndex(e => e.BANK_NO)
                    .HasName("BANKING_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ACC_NM).HasMaxLength(80);

                entity.Property(e => e.ADDR).HasMaxLength(80);

                entity.Property(e => e.ADDR2).HasMaxLength(80);

                entity.Property(e => e.ADDR2_E).HasMaxLength(80);

                entity.Property(e => e.ADDR_E).HasMaxLength(80);

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.BANK_NM).HasMaxLength(80);

                entity.Property(e => e.BANK_NM_E).HasMaxLength(80);

                entity.Property(e => e.BANK_NO)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.BRANCH_NM).HasMaxLength(80);

                entity.Property(e => e.BRANCH_NO).HasMaxLength(10);

                entity.Property(e => e.CLAS_NO).HasMaxLength(10);

                entity.Property(e => e.CONTACTER).HasMaxLength(30);

                entity.Property(e => e.CONTACTER2).HasMaxLength(30);

                entity.Property(e => e.CONTACTER3).HasMaxLength(30);

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.E_MAIL).HasMaxLength(80);

                entity.Property(e => e.FAX_NO).HasMaxLength(20);

                entity.Property(e => e.FULL_NM).HasMaxLength(80);

                entity.Property(e => e.FULL_NM_E).HasMaxLength(80);

                entity.Property(e => e.HEAD_NM).HasMaxLength(80);

                entity.Property(e => e.HEAD_NO).HasMaxLength(10);

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.REMK).HasMaxLength(255);

                entity.Property(e => e.TEL_NO).HasMaxLength(20);

                entity.Property(e => e.TEL_NO2).HasMaxLength(20);

                entity.Property(e => e.TEL_NO3).HasMaxLength(20);

                entity.Property(e => e.WWW).HasMaxLength(80);
            });

            modelBuilder.Entity<CITEM>(entity =>
            {
                entity.HasIndex(e => e.CITEM_NO)
                    .HasName("CITEM_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.CITEM_NM)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CITEM_NO)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CITEM_TY)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CR_ACT_NO)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CR_BCH_NO)
                    .HasMaxLength(24)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.DR_ACT_NO)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.DR_BCH_NO)
                    .HasMaxLength(24)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.REMK)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.VITEM_NO)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<CONTR>(entity =>
            {
                entity.HasIndex(e => e.CN_NO)
                    .HasName("CONTR_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ADDR)
                    .HasMaxLength(80)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.B_DT).HasColumnType("datetime");

                entity.Property(e => e.CN_NO)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CN_TY)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CORP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CS_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_STA)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.DEPM_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.DEPOSIT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DOC_NO)
                    .HasMaxLength(80)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.E_DT).HasColumnType("datetime");

                entity.Property(e => e.FULL_NM)
                    .HasMaxLength(80)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IVC_DEPM_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IVC_GRP)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IVC_MODE)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IVC_REMK).HasMaxLength(255);

                entity.Property(e => e.IVC_TY).HasDefaultValueSql("''");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PRD).HasDefaultValueSql("0");

                entity.Property(e => e.REMK)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SHORT_NM)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TAX_RT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TAX_TY)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.T_DT).HasColumnType("datetime");
            });

            modelBuilder.Entity<CONTRBUG>(entity =>
            {
                entity.HasIndex(e => new { e.PID, e.ID })
                    .HasName("CONTRBUG_X9")
                    .IsUnique();

                entity.HasIndex(e => new { e.VCH_TY, e.VCH_NO, e.VCH_SR })
                    .HasName("CONTRBUG_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ACT_NO)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.AMT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_BUG)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PID).HasDefaultValueSql("newid()");

                entity.Property(e => e.REMK)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.VCH_NO)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.VCH_SR).HasDefaultValueSql("0");

                entity.Property(e => e.VCH_TY)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.YYYYMM)
                    .HasMaxLength(6)
                    .HasDefaultValueSql("''");

                entity.HasOne(d => d.P)
                    .WithMany(p => p.CONTRBUG)
                    .HasForeignKey(d => d.PID)
                    .HasConstraintName("FK_CONTRBUG_CONTRMT");
            });

            modelBuilder.Entity<CONTRCITEM>(entity =>
            {
                entity.HasIndex(e => new { e.PID, e.ID })
                    .HasName("CONTRCITEM_X9")
                    .IsUnique();

                entity.HasIndex(e => new { e.VCH_TY, e.VCH_NO, e.VCH_SR })
                    .HasName("CONTRCITEM_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ACT_NO)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.AMT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AMT_MM)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AR_PRD)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BCH_NO)
                    .HasMaxLength(24)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.B_DT).HasColumnType("datetime");

                entity.Property(e => e.CITEM_NO)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_EXP)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_STA)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.E_DT).HasColumnType("datetime");

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IVC_MODE)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IVC_TY).HasDefaultValueSql("''");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PID).HasDefaultValueSql("newid()");

                entity.Property(e => e.PRD).HasDefaultValueSql("0");

                entity.Property(e => e.REMK)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SRV_MM).HasDefaultValueSql("0");

                entity.Property(e => e.TAX_RT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TAX_TY)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.VCH_NO)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.VCH_SR).HasDefaultValueSql("0");

                entity.Property(e => e.VCH_TY)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasDefaultValueSql("''");

                entity.HasOne(d => d.P)
                    .WithMany(p => p.CONTRCITEM)
                    .HasForeignKey(d => d.PID)
                    .HasConstraintName("FK_CONTRCITEM_CONTRMT");
            });

            modelBuilder.Entity<CONTRCITEMAR>(entity =>
            {
                entity.HasIndex(e => new { e.PID, e.ID })
                    .HasName("CONTRCITEMAR_X9")
                    .IsUnique();

                entity.HasIndex(e => new { e.VCH_TY, e.VCH_NO, e.VCH_SR, e.CITEM_SR })
                    .HasName("CONTRCITEMAR_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.AR_AMT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AR_NO)
                    .HasMaxLength(15)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.AR_TY)
                    .HasMaxLength(4)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.AR_YYYYMM)
                    .HasMaxLength(6)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.B_DT).HasColumnType("datetime");

                entity.Property(e => e.CITEM_SR).HasDefaultValueSql("0");

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_ACT)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_PR).HasMaxLength(1);

                entity.Property(e => e.E_DT).HasColumnType("datetime");

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IVC_AMT).HasColumnType("decimal");

                entity.Property(e => e.IVC_TAX).HasColumnType("decimal");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PID).HasDefaultValueSql("newid()");

                entity.Property(e => e.PR_NO).HasMaxLength(15);

                entity.Property(e => e.PR_TY).HasMaxLength(4);

                entity.Property(e => e.REMK)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TAX_AMT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VCH_NO)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.VCH_SR).HasDefaultValueSql("0");

                entity.Property(e => e.VCH_TY)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasDefaultValueSql("''");

                entity.HasOne(d => d.P)
                    .WithMany(p => p.CONTRCITEMAR)
                    .HasForeignKey(d => d.PID)
                    .HasConstraintName("FK_CONTRCITEMAR_CONTRCITEM");
            });

            modelBuilder.Entity<CONTRMT>(entity =>
            {
                entity.HasIndex(e => new { e.VCH_TY, e.VCH_NO })
                    .HasName("CONTRMT_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.AR_DEPM_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.B_DT).HasColumnType("datetime");

                entity.Property(e => e.CFM_DT).HasColumnType("datetime");

                entity.Property(e => e.CFM_USR_NO).HasMaxLength(10);

                entity.Property(e => e.CN_NO)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CORP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CS_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_CFM)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_SIGN)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_STA)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.DEPM_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.E_DT).HasColumnType("datetime");

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IVC_GRP)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IVC_MODE)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IVC_TY).HasDefaultValueSql("''");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.N_PRT).HasDefaultValueSql("0");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PRD).HasDefaultValueSql("0");

                entity.Property(e => e.REMK)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SER_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TAX_RT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TAX_TY)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.T_DT).HasColumnType("datetime");

                entity.Property(e => e.VCH_DT).HasColumnType("datetime");

                entity.Property(e => e.VCH_NO)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.VCH_TY)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<CORP>(entity =>
            {
                entity.HasIndex(e => e.CORP_NO)
                    .HasName("CORP_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ACC_NM).HasMaxLength(80);

                entity.Property(e => e.ACC_NO).HasMaxLength(80);

                entity.Property(e => e.ADDR).HasMaxLength(80);

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.BANK_NO).HasMaxLength(10);

                entity.Property(e => e.CONTACTER).HasMaxLength(80);

                entity.Property(e => e.CORP_NM).HasMaxLength(80);

                entity.Property(e => e.CORP_NO)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CR_ACT_NO).HasMaxLength(20);

                entity.Property(e => e.DCL_NO).HasMaxLength(10);

                entity.Property(e => e.DR_ACT_NO).HasMaxLength(20);

                entity.Property(e => e.DUTY_NM).HasMaxLength(10);

                entity.Property(e => e.FAX_NO).HasMaxLength(20);

                entity.Property(e => e.GVM_NO).HasMaxLength(10);

                entity.Property(e => e.HIS_ID).HasMaxLength(20);

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.LIS_ID).HasMaxLength(20);

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PROPRIETOR).HasMaxLength(80);

                entity.Property(e => e.REMK).HasMaxLength(255);

                entity.Property(e => e.SHORT_NM).HasMaxLength(20);

                entity.Property(e => e.TAXRGT_NO).HasMaxLength(20);

                entity.Property(e => e.TAX_CITY).HasMaxLength(10);

                entity.Property(e => e.TAX_DEPM).HasMaxLength(10);

                entity.Property(e => e.TEL_NO).HasMaxLength(20);

                entity.Property(e => e.TEL_NO2).HasMaxLength(20);

                entity.Property(e => e.TEL_NO3).HasMaxLength(20);

                entity.Property(e => e.UNIQUE_NO).HasMaxLength(20);

                entity.Property(e => e.ZNO_ADDR).HasMaxLength(10);
            });

            modelBuilder.Entity<CPADDDL>(entity =>
            {
                entity.HasIndex(e => new { e.ID, e.PID })
                    .HasName("CPADDDL_X9")
                    .IsUnique();

                entity.HasIndex(e => new { e.YYYYMM, e.CORP_NO, e.EMP_NO })
                    .HasName("CPADDDL_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.CORP_NO)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.EMP_NO)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ISU_SLY)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.REMK).HasMaxLength(255);

                entity.Property(e => e.TAX_INC)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.YYYYMM)
                    .IsRequired()
                    .HasMaxLength(6);

                entity.HasOne(d => d.P)
                    .WithMany(p => p.CPADDDL)
                    .HasForeignKey(d => d.PID)
                    .HasConstraintName("FK_CPADDDL_CPADDMT");
            });

            modelBuilder.Entity<CPADDMT>(entity =>
            {
                entity.HasIndex(e => new { e.YYYYMM, e.CORP_NO })
                    .HasName("CPADDMT_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.ADD_EXP)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CORP_NO)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.HIS_AMT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OTH_AMT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.REMK).HasMaxLength(255);

                entity.Property(e => e.SLY_AMT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.YYYYMM)
                    .IsRequired()
                    .HasMaxLength(6);
            });

            modelBuilder.Entity<CTARACT>(entity =>
            {
                entity.HasIndex(e => new { e.PID, e.ID })
                    .HasName("CTARACT_X9")
                    .IsUnique();

                entity.HasIndex(e => new { e.VCH_TY, e.VCH_NO, e.SR })
                    .HasName("CTARACT_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ACT_NO)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.AMT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BCH_NO)
                    .HasMaxLength(24)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CN_NO)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CS_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_DCR).HasDefaultValueSql("0");

                entity.Property(e => e.DEPM_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.EMP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PID).HasDefaultValueSql("newid()");

                entity.Property(e => e.REMK)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SER_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SR).HasDefaultValueSql("0");

                entity.Property(e => e.VCH_NO)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.VCH_TY)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasDefaultValueSql("''");

                entity.HasOne(d => d.P)
                    .WithMany(p => p.CTARACT)
                    .HasForeignKey(d => d.PID)
                    .HasConstraintName("FK_CTARACT_CTARMT");
            });

            modelBuilder.Entity<CTARDL>(entity =>
            {
                entity.HasIndex(e => new { e.PID, e.ID })
                    .HasName("CTARDL_X9")
                    .IsUnique();

                entity.HasIndex(e => new { e.VCH_TY, e.VCH_NO, e.VCH_SR })
                    .HasName("CTARDL_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ACT_NO)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ACT_REMK)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.AR_AMT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BCH_NO)
                    .HasMaxLength(24)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.B_DT).HasColumnType("datetime");

                entity.Property(e => e.CITEM_SR).HasDefaultValueSql("0");

                entity.Property(e => e.CONTR_NO)
                    .HasMaxLength(15)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CONTR_SR).HasDefaultValueSql("0");

                entity.Property(e => e.CONTR_TY)
                    .HasMaxLength(4)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CPS_AMT).HasColumnType("decimal");

                entity.Property(e => e.CPS_TAX).HasColumnType("decimal");

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_PR).HasMaxLength(1);

                entity.Property(e => e.C_SOURCE).HasMaxLength(1);

                entity.Property(e => e.DR_AMT).HasColumnType("decimal");

                entity.Property(e => e.DS_AMT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.E_DT).HasColumnType("datetime");

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IVC_AMT).HasColumnType("decimal");

                entity.Property(e => e.IVC_TAX).HasColumnType("decimal");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PID).HasDefaultValueSql("newid()");

                entity.Property(e => e.PR_NO).HasMaxLength(15);

                entity.Property(e => e.PR_TY).HasMaxLength(4);

                entity.Property(e => e.RCD_AMT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.REMK)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TAX_AMT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VCH_NO)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.VCH_SR).HasDefaultValueSql("0");

                entity.Property(e => e.VCH_TY)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasDefaultValueSql("''");

                entity.HasOne(d => d.P)
                    .WithMany(p => p.CTARDL)
                    .HasForeignKey(d => d.PID)
                    .HasConstraintName("FK_CTARDL_CTARMT");
            });

            modelBuilder.Entity<CTARMT>(entity =>
            {
                entity.HasIndex(e => new { e.VCH_TY, e.VCH_NO })
                    .HasName("CTARMT_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.AR_ACT_NO)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.AR_AMT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AR_AVCH_NO).HasMaxLength(15);

                entity.Property(e => e.AR_AVCH_TY).HasMaxLength(4);

                entity.Property(e => e.AR_BCH_NO)
                    .HasMaxLength(24)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.AR_REMK)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.B_UNIQUE_NO)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CFM_DT).HasColumnType("datetime");

                entity.Property(e => e.CFM_USR_NO).HasMaxLength(10);

                entity.Property(e => e.CORP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CPS_AMT).HasColumnType("decimal");

                entity.Property(e => e.CPS_TAX).HasColumnType("decimal");

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CS_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_AJS_AR)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_AJS_PRCV)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_CFM)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_IVC)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_PRCV)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_SIGN)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.DR_AMT).HasColumnType("decimal");

                entity.Property(e => e.DS_AMT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FULL_NM)
                    .HasMaxLength(80)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IVC_AMT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IVC_DT).HasColumnType("datetime");

                entity.Property(e => e.IVC_GRP)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IVC_NO)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IVC_PAGE)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IVC_TAX)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.N_PRT).HasDefaultValueSql("0");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PR_ACT_NO)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PR_AVCH_NO).HasMaxLength(15);

                entity.Property(e => e.PR_AVCH_TY).HasMaxLength(4);

                entity.Property(e => e.PR_BCH_NO)
                    .HasMaxLength(24)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PR_REMK)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RCD_AMT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.REMK)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.S_UNIQUE_NO)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TAX_AMT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TAX_RT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TAX_TY)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.VCH_DT).HasColumnType("datetime");

                entity.Property(e => e.VCH_NO)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.VCH_TY)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.YYYYMM)
                    .HasMaxLength(6)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<CTARPACT>(entity =>
            {
                entity.HasIndex(e => new { e.PID, e.ID })
                    .HasName("CTARPACT_X9")
                    .IsUnique();

                entity.HasIndex(e => new { e.VCH_TY, e.VCH_NO, e.SR })
                    .HasName("CTARPACT_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ACT_NO)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.AMT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BCH_NO)
                    .HasMaxLength(24)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CN_NO)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CS_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_DCR).HasDefaultValueSql("0");

                entity.Property(e => e.DEPM_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.EMP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PID).HasDefaultValueSql("newid()");

                entity.Property(e => e.REMK)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SER_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SR).HasDefaultValueSql("0");

                entity.Property(e => e.VCH_NO)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.VCH_TY)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasDefaultValueSql("''");

                entity.HasOne(d => d.P)
                    .WithMany(p => p.CTARPACT)
                    .HasForeignKey(d => d.PID)
                    .HasConstraintName("FK_CTARPACT_CTARMT");
            });

            modelBuilder.Entity<CTDRACT>(entity =>
            {
                entity.HasIndex(e => new { e.PID, e.ID })
                    .HasName("CTDRACT_X9")
                    .IsUnique();

                entity.HasIndex(e => new { e.VCH_TY, e.VCH_NO, e.SR })
                    .HasName("CTDRACT_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ACT_NO)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.AMT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BCH_NO)
                    .HasMaxLength(24)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CN_NO)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CS_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_DCR).HasDefaultValueSql("0");

                entity.Property(e => e.DEPM_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.EMP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PID).HasDefaultValueSql("newid()");

                entity.Property(e => e.REMK)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SER_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SR).HasDefaultValueSql("0");

                entity.Property(e => e.VCH_NO)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.VCH_TY)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasDefaultValueSql("''");

                entity.HasOne(d => d.P)
                    .WithMany(p => p.CTDRACT)
                    .HasForeignKey(d => d.PID)
                    .HasConstraintName("FK_CTDRACT_CTDRMT");
            });

            modelBuilder.Entity<CTDRAR>(entity =>
            {
                entity.HasIndex(e => new { e.PID, e.ID })
                    .HasName("CTDRAR_X9")
                    .IsUnique();

                entity.HasIndex(e => new { e.VCH_TY, e.VCH_NO, e.VCH_SR })
                    .HasName("CTDRAR_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.AR_NO)
                    .HasMaxLength(15)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.AR_SR).HasDefaultValueSql("0");

                entity.Property(e => e.AR_TY)
                    .HasMaxLength(4)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_SOURCE)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.DR_AMT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DS_AMT).HasColumnType("decimal");

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IVC_TAX)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PID).HasDefaultValueSql("newid()");

                entity.Property(e => e.RCD_AMT).HasColumnType("decimal");

                entity.Property(e => e.REMK)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.VCH_NO)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.VCH_SR).HasDefaultValueSql("0");

                entity.Property(e => e.VCH_TY)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasDefaultValueSql("''");

                entity.HasOne(d => d.P)
                    .WithMany(p => p.CTDRAR)
                    .HasForeignKey(d => d.PID)
                    .HasConstraintName("FK_CTDRAR_CTDRMT");
            });

            modelBuilder.Entity<CTDRDL>(entity =>
            {
                entity.HasIndex(e => new { e.PID, e.ID })
                    .HasName("CTDRDL_X9")
                    .IsUnique();

                entity.HasIndex(e => new { e.VCH_TY, e.VCH_NO, e.VCH_SR })
                    .HasName("CTDRDL_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.DR_AMT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IVC_DT).HasColumnType("datetime");

                entity.Property(e => e.IVC_NO)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IVC_PAGE)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IVC_TAX)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PID).HasDefaultValueSql("newid()");

                entity.Property(e => e.PRC)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.QTY)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.REMK)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.UNIT)
                    .HasMaxLength(4)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.VCH_NO)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.VCH_SR).HasDefaultValueSql("0");

                entity.Property(e => e.VCH_TY)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.VITEM_NM)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.VITEM_NO)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.HasOne(d => d.P)
                    .WithMany(p => p.CTDRDL)
                    .HasForeignKey(d => d.PID)
                    .HasConstraintName("FK_CTDRDL_CTDRMT");
            });

            modelBuilder.Entity<CTDRMT>(entity =>
            {
                entity.HasIndex(e => new { e.VCH_TY, e.VCH_NO })
                    .HasName("CTDRMT_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.AR_ACT_NO).HasMaxLength(20);

                entity.Property(e => e.AR_BCH_NO).HasMaxLength(24);

                entity.Property(e => e.AVCH_NO)
                    .HasMaxLength(15)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.AVCH_TY)
                    .HasMaxLength(4)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.B_UNIQUE_NO)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CFM_DT).HasColumnType("datetime");

                entity.Property(e => e.CFM_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CORP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CS_ADDR)
                    .HasMaxLength(80)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CS_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_AJS)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_CFM)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_SIGN)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.DR_AMT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DS_AMT).HasColumnType("decimal");

                entity.Property(e => e.FULL_NM)
                    .HasMaxLength(80)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IVC_TAX)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.N_PRT).HasDefaultValueSql("0");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RCD_AMT).HasColumnType("decimal");

                entity.Property(e => e.REMK)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.S_UNIQUE_NO)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.VCH_DT).HasColumnType("datetime");

                entity.Property(e => e.VCH_NO)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.VCH_TY)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<CTPRACT>(entity =>
            {
                entity.HasIndex(e => new { e.PID, e.ID })
                    .HasName("CTPRACT_X9")
                    .IsUnique();

                entity.HasIndex(e => new { e.VCH_TY, e.VCH_NO, e.SR })
                    .HasName("CTPRACT_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ACT_NO)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.AMT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BCH_NO)
                    .HasMaxLength(24)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CN_NO)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CS_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_DCR).HasDefaultValueSql("0");

                entity.Property(e => e.DEPM_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.EMP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PID).HasDefaultValueSql("newid()");

                entity.Property(e => e.REMK)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SER_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SR).HasDefaultValueSql("0");

                entity.Property(e => e.VCH_NO)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.VCH_TY)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasDefaultValueSql("''");

                entity.HasOne(d => d.P)
                    .WithMany(p => p.CTPRACT)
                    .HasForeignKey(d => d.PID)
                    .HasConstraintName("FK_CTPRACT_CTPRMT");
            });

            modelBuilder.Entity<CTPRDL>(entity =>
            {
                entity.HasIndex(e => new { e.PID, e.ID })
                    .HasName("CTPRDL_X9")
                    .IsUnique();

                entity.HasIndex(e => new { e.VCH_TY, e.VCH_NO, e.VCH_SR })
                    .HasName("CTPRDL_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ACT_NO)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ACT_REMK)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.BCH_NO)
                    .HasMaxLength(24)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.B_DT).HasColumnType("datetime");

                entity.Property(e => e.CITEM_SR).HasDefaultValueSql("0");

                entity.Property(e => e.CONTR_NO)
                    .HasMaxLength(15)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CONTR_SR).HasDefaultValueSql("0");

                entity.Property(e => e.CONTR_TY)
                    .HasMaxLength(4)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CPS_AMT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CPS_TAX)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.DR_AMT).HasColumnType("decimal");

                entity.Property(e => e.DS_AMT).HasColumnType("decimal");

                entity.Property(e => e.E_DT).HasColumnType("datetime");

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IVC_AMT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IVC_TAX)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PID).HasDefaultValueSql("newid()");

                entity.Property(e => e.PR_AMT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RCD_AMT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.REMK)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TAX_AMT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VCH_NO)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.VCH_SR).HasDefaultValueSql("0");

                entity.Property(e => e.VCH_TY)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasDefaultValueSql("''");

                entity.HasOne(d => d.P)
                    .WithMany(p => p.CTPRDL)
                    .HasForeignKey(d => d.PID)
                    .HasConstraintName("FK_CTPRDL_CTPRMT");
            });

            modelBuilder.Entity<CTPRMT>(entity =>
            {
                entity.HasIndex(e => new { e.VCH_TY, e.VCH_NO })
                    .HasName("CTPRMT_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.AR_ACT_NO).HasMaxLength(20);

                entity.Property(e => e.AR_BCH_NO).HasMaxLength(24);

                entity.Property(e => e.B_UNIQUE_NO)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CFM_DT).HasColumnType("datetime");

                entity.Property(e => e.CFM_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CORP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CPS_AMT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CPS_TAX)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CS_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_AJS_PR)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_CFM)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_IVC)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_SIGN)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.DR_AMT).HasColumnType("decimal");

                entity.Property(e => e.DS_AMT).HasColumnType("decimal");

                entity.Property(e => e.FULL_NM)
                    .HasMaxLength(80)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IVC_AMT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IVC_DT).HasColumnType("datetime");

                entity.Property(e => e.IVC_GRP)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IVC_NO)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IVC_PAGE)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IVC_TAX)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.N_PRT).HasDefaultValueSql("0");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PR_ACT_NO)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PR_AMT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PR_AVCH_NO)
                    .HasMaxLength(15)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PR_AVCH_TY)
                    .HasMaxLength(4)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PR_BCH_NO)
                    .HasMaxLength(24)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PR_REMK)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RCD_AMT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.REMK)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.S_UNIQUE_NO)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TAX_AMT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TAX_RT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TAX_TY)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.VCH_DT).HasColumnType("datetime");

                entity.Property(e => e.VCH_NO)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.VCH_TY)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.YYYYMM)
                    .HasMaxLength(6)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<CTRARACT>(entity =>
            {
                entity.HasIndex(e => new { e.PID, e.ID })
                    .HasName("CTRARACT_X9")
                    .IsUnique();

                entity.HasIndex(e => new { e.VCH_TY, e.VCH_NO, e.SR })
                    .HasName("CTRARACT_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ACT_NO)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.AMT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BCH_NO)
                    .HasMaxLength(24)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CN_NO)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CS_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_DCR).HasDefaultValueSql("0");

                entity.Property(e => e.DEPM_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.EMP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PID).HasDefaultValueSql("newid()");

                entity.Property(e => e.REMK)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SER_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SR).HasDefaultValueSql("0");

                entity.Property(e => e.VCH_NO)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.VCH_TY)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasDefaultValueSql("''");

                entity.HasOne(d => d.P)
                    .WithMany(p => p.CTRARACT)
                    .HasForeignKey(d => d.PID)
                    .HasConstraintName("FK_CTRARACT_CTRARMT");
            });

            modelBuilder.Entity<CTRARDL>(entity =>
            {
                entity.HasIndex(e => new { e.PID, e.ID })
                    .HasName("CTRARDL_X9")
                    .IsUnique();

                entity.HasIndex(e => new { e.VCH_TY, e.VCH_NO, e.VCH_SR })
                    .HasName("CTRARDL_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ACT_NO)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ACT_REMK)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.AR_AMT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AR_NO)
                    .HasMaxLength(15)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.AR_SR).HasDefaultValueSql("0");

                entity.Property(e => e.AR_TY)
                    .HasMaxLength(4)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.BCH_NO)
                    .HasMaxLength(24)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CPS_AMT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_SOURCE).HasMaxLength(1);

                entity.Property(e => e.DS_ACT_NO)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.DS_AMT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DS_BCH_NO)
                    .HasMaxLength(24)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.DS_REMK)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PID).HasDefaultValueSql("newid()");

                entity.Property(e => e.REMK)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.UR_AMT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VCH_NO)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.VCH_SR).HasDefaultValueSql("0");

                entity.Property(e => e.VCH_TY)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasDefaultValueSql("''");

                entity.HasOne(d => d.P)
                    .WithMany(p => p.CTRARDL)
                    .HasForeignKey(d => d.PID)
                    .HasConstraintName("FK_CTRARDL_CTRARMT");
            });

            modelBuilder.Entity<CTRARML>(entity =>
            {
                entity.HasIndex(e => new { e.PID, e.ID })
                    .HasName("CTRARML_X9")
                    .IsUnique();

                entity.HasIndex(e => new { e.VCH_TY, e.VCH_NO, e.VCH_SR })
                    .HasName("CTRARML_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ACT_NO)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ACT_REMK)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.AMT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BANK_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.BCH_NO)
                    .HasMaxLength(24)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.DW_DT).HasColumnType("datetime");

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PID).HasDefaultValueSql("newid()");

                entity.Property(e => e.RAR_TY)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.REMK)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.VCH_NO)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.VCH_SR).HasDefaultValueSql("0");

                entity.Property(e => e.VCH_TY)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasDefaultValueSql("''");

                entity.HasOne(d => d.P)
                    .WithMany(p => p.CTRARML)
                    .HasForeignKey(d => d.PID)
                    .HasConstraintName("FK_CTRARML_CTRARMT");
            });

            modelBuilder.Entity<CTRARMT>(entity =>
            {
                entity.HasIndex(e => new { e.VCH_TY, e.VCH_NO })
                    .HasName("CTRARMT_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.AVCH_NO)
                    .HasMaxLength(15)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.AVCH_TY)
                    .HasMaxLength(4)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CFM_DT).HasColumnType("datetime");

                entity.Property(e => e.CFM_USR_NO).HasMaxLength(10);

                entity.Property(e => e.CORP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CPS_AMT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CS_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_AJS)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_CFM)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_SIGN)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.N_PRT).HasDefaultValueSql("0");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.REMK)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.VCH_DT).HasColumnType("datetime");

                entity.Property(e => e.VCH_NO)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.VCH_TY)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<CTRARNOTR>(entity =>
            {
                entity.HasIndex(e => new { e.PID, e.ID })
                    .HasName("CTRARNOTR_X9")
                    .IsUnique();

                entity.HasIndex(e => new { e.VCH_TY, e.VCH_NO, e.VCH_SR })
                    .HasName("CTRARNOTR_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ACT_NO)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ACT_REMK)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.AMT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BCH_NO)
                    .HasMaxLength(24)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_BANK_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_CS)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.DUE_DT).HasColumnType("datetime");

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.NOT_NO)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PCASH_DT).HasColumnType("datetime");

                entity.Property(e => e.PID).HasDefaultValueSql("newid()");

                entity.Property(e => e.P_ACC_NO)
                    .HasMaxLength(80)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.P_BANK_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RCV_DT).HasColumnType("datetime");

                entity.Property(e => e.REMK)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.VCH_NO)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.VCH_SR).HasDefaultValueSql("0");

                entity.Property(e => e.VCH_TY)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasDefaultValueSql("''");

                entity.HasOne(d => d.P)
                    .WithMany(p => p.CTRARNOTR)
                    .HasForeignKey(d => d.PID)
                    .HasConstraintName("FK_CTRARNOTR_CTRARMT");
            });

            modelBuilder.Entity<CUSTOMER>(entity =>
            {
                entity.HasIndex(e => e.CS_NO)
                    .HasName("CUSTOMER_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ADDR)
                    .HasMaxLength(80)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.AR_ACT_NO)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.AR_BCH_NO)
                    .HasMaxLength(24)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CONTACTER)
                    .HasMaxLength(80)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CONTACTER2)
                    .HasMaxLength(80)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CONTACTER3)
                    .HasMaxLength(80)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CORP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CS_NO)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.DEPM_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.EAR_ACT_NO).HasMaxLength(20);

                entity.Property(e => e.EAR_BCH_NO).HasMaxLength(24);

                entity.Property(e => e.FAX_NO)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.FULL_NM)
                    .HasMaxLength(80)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IVC_DAY).HasDefaultValueSql("0");

                entity.Property(e => e.IVC_MM).HasDefaultValueSql("0");

                entity.Property(e => e.IVC_MODE)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.NR_ACT_NO)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.NR_BCH_NO)
                    .HasMaxLength(24)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PROPRIETOR)
                    .HasMaxLength(80)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PR_ACT_NO)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PR_BCH_NO)
                    .HasMaxLength(24)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.REMK)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SHORT_NM)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TAX_RT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TAX_TY)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TEL_NO)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TEL_NO2)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TEL_NO3)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.UNIQUE_NO)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<DEPM>(entity =>
            {
                entity.HasIndex(e => e.DEPM_NO)
                    .HasName("DEPM_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_TY).HasMaxLength(1);

                entity.Property(e => e.DEPM_NM).HasMaxLength(20);

                entity.Property(e => e.DEPM_NO)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.REMK).HasMaxLength(255);

                entity.Property(e => e.U_DEPM_NO).HasMaxLength(10);
            });

            modelBuilder.Entity<DEPMCAL>(entity =>
            {
                entity.HasIndex(e => new { e.DEPM_NO, e.D_DEPM_NO })
                    .HasName("DEPMCAL_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.DEPM_NO)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.D_DEPM_NO)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<DEPMLEV>(entity =>
            {
                entity.HasIndex(e => new { e.DEPM_NO, e.D_DEPM_NO })
                    .HasName("DEPMLEV_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_SOURCE)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.DEPM_NO)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.D_DEPM_NO)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<EIPFRL>(entity =>
            {
                entity.HasIndex(e => new { e.FRL_DT, e.EMP_NO, e.FRL_NO })
                    .HasName("EIPFRL_X1");

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.EMP_NO)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.FRL_DT).HasColumnType("datetime");

                entity.Property(e => e.FRL_HR)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FRL_NO)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.REMK)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SID).HasDefaultValueSql("newid()");
            });

            modelBuilder.Entity<EIPWRK>(entity =>
            {
                entity.HasIndex(e => new { e.WRK_DT, e.EMP_NO, e.SER_NO, e.JOB_NO })
                    .HasName("EIPWRK_X1");

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_CFM)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.EMP_NO)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.JOB_NO)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.REMK)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SER_NO)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SID).HasDefaultValueSql("newid()");

                entity.Property(e => e.WRK_DT).HasColumnType("datetime");

                entity.Property(e => e.WRK_HR)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<EMPALW>(entity =>
            {
                entity.HasIndex(e => new { e.EMP_NO, e.PMS_NO })
                    .HasName("EMPALW_X1")
                    .IsUnique();

                entity.HasIndex(e => new { e.PID, e.ID })
                    .HasName("EMPALW_X9")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.AMT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BAS_HR_28).HasDefaultValueSql("0");

                entity.Property(e => e.BAS_HR_29).HasDefaultValueSql("0");

                entity.Property(e => e.BAS_HR_30).HasDefaultValueSql("0");

                entity.Property(e => e.BAS_HR_31).HasDefaultValueSql("0");

                entity.Property(e => e.CORP_NO).HasMaxLength(10);

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_TY)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.EMP_NO)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PID).HasDefaultValueSql("newid()");

                entity.Property(e => e.PMS_NO)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.REMK)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.HasOne(d => d.P)
                    .WithMany(p => p.EMPALW)
                    .HasForeignKey(d => d.PID)
                    .HasConstraintName("FK_EMPALW_EMPLOYEE");
            });

            modelBuilder.Entity<EMPCORP>(entity =>
            {
                entity.HasIndex(e => new { e.EMP_NO, e.CORP_NO })
                    .HasName("EMPCORP_X1")
                    .IsUnique();

                entity.HasIndex(e => new { e.ID, e.PID })
                    .HasName("EMPCORP_X9")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.ARV_DT).HasColumnType("datetime");

                entity.Property(e => e.CORP_NO)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_SAL_TY).HasMaxLength(1);

                entity.Property(e => e.DEPM_NO).HasMaxLength(10);

                entity.Property(e => e.EMP_NO)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.LEV_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SER_NO).HasMaxLength(10);

                entity.HasOne(d => d.P)
                    .WithMany(p => p.EMPCORP)
                    .HasForeignKey(d => d.PID)
                    .HasConstraintName("FK_EMPCORP_EMPLOYEE");
            });

            modelBuilder.Entity<EMPDRAW>(entity =>
            {
                entity.HasIndex(e => new { e.EMP_NO, e.DRAW_NO })
                    .HasName("EMPDRAW_X1")
                    .IsUnique();

                entity.HasIndex(e => new { e.ID, e.PID })
                    .HasName("EMPDRAW_X9")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.AMT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AMTED)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_CLS).HasMaxLength(1);

                entity.Property(e => e.C_PRD).HasMaxLength(1);

                entity.Property(e => e.C_SOURCE).HasMaxLength(1);

                entity.Property(e => e.DDT_DT).HasColumnType("datetime");

                entity.Property(e => e.DRAW_DT).HasColumnType("datetime");

                entity.Property(e => e.DRAW_NO)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.EMP_NO)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MM_AMT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PMS_NO).HasMaxLength(10);

                entity.Property(e => e.REMK).HasMaxLength(255);

                entity.HasOne(d => d.P)
                    .WithMany(p => p.EMPDRAW)
                    .HasForeignKey(d => d.PID)
                    .HasConstraintName("FK_EMPDRAW_EMPLOYEE");
            });

            modelBuilder.Entity<EMPEQUIP>(entity =>
            {
                entity.HasIndex(e => new { e.ID, e.PID })
                    .HasName("EMPEQUIP_X9")
                    .IsUnique();

                entity.HasIndex(e => new { e.EMP_NO, e.EQUIP_NO, e.ISS_DT })
                    .HasName("EMPEQUIP_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.AMT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AMTED)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_CLS).HasMaxLength(1);

                entity.Property(e => e.C_SOURCE).HasMaxLength(1);

                entity.Property(e => e.DDT_DT).HasColumnType("datetime");

                entity.Property(e => e.EMP_NO)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.EQUIP_NO)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ISS_AMT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ISS_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MM_AMT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PRC)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.QTY)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.REMK).HasMaxLength(255);

                entity.HasOne(d => d.P)
                    .WithMany(p => p.EMPEQUIP)
                    .HasForeignKey(d => d.PID)
                    .HasConstraintName("FK_EMPEQUIP_EMPLOYEE");
            });

            modelBuilder.Entity<EMPEXAM>(entity =>
            {
                entity.HasIndex(e => new { e.EMP_NO, e.EXAM_DT })
                    .HasName("EMPEXAM_X1")
                    .IsUnique();

                entity.HasIndex(e => new { e.ID, e.PID })
                    .HasName("EMPEXAM_X9")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.AC)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.BMI)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CHOL)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.DBP)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EMP_NO)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.EXAM_DT).HasColumnType("datetime");

                entity.Property(e => e.HEIGHT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.NEXT_DT).HasColumnType("datetime");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.REMK).HasMaxLength(255);

                entity.Property(e => e.SBP)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TG)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.WEIGHT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.P)
                    .WithMany(p => p.EMPEXAM)
                    .HasForeignKey(d => d.PID)
                    .HasConstraintName("FK_EMPEXAM_EMPLOYEE");
            });

            modelBuilder.Entity<EMPFM>(entity =>
            {
                entity.HasIndex(e => new { e.EMP_NO, e.ID_NO })
                    .HasName("EMPFM_X1")
                    .IsUnique();

                entity.HasIndex(e => new { e.ID, e.PID })
                    .HasName("EMPFM_X9")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.ADD_NO).HasMaxLength(10);

                entity.Property(e => e.ADD_RT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BRD_DT).HasColumnType("datetime");

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_SOURCE).HasMaxLength(1);

                entity.Property(e => e.EMP_NO)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.FA_NM).HasMaxLength(20);

                entity.Property(e => e.ID_NO)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ISU_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RELA).HasMaxLength(20);

                entity.Property(e => e.REMK).HasMaxLength(255);

                entity.Property(e => e.RIS_DT).HasColumnType("datetime");

                entity.HasOne(d => d.P)
                    .WithMany(p => p.EMPFM)
                    .HasForeignKey(d => d.PID)
                    .HasConstraintName("FK_EMPFM_EMPLOYEE");
            });

            modelBuilder.Entity<EMPFMCHG>(entity =>
            {
                entity.HasIndex(e => new { e.ID, e.PID })
                    .HasName("EMPFMCHG_X9")
                    .IsUnique();

                entity.HasIndex(e => new { e.EMP_NO, e.CHG_DT, e.ID_NO })
                    .HasName("EMPFMCHG_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ADD_AMT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.ADD_NO).HasMaxLength(10);

                entity.Property(e => e.ADD_RT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BRD_DT).HasColumnType("datetime");

                entity.Property(e => e.CHG_DT).HasColumnType("datetime");

                entity.Property(e => e.CHG_TY).HasMaxLength(1);

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_CLS).HasMaxLength(1);

                entity.Property(e => e.C_SOURCE).HasMaxLength(1);

                entity.Property(e => e.EMP_NO)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.FA_NM).HasMaxLength(20);

                entity.Property(e => e.ID_NO)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RELA).HasMaxLength(20);

                entity.Property(e => e.REMK).HasMaxLength(255);

                entity.HasOne(d => d.P)
                    .WithMany(p => p.EMPFMCHG)
                    .HasForeignKey(d => d.PID)
                    .HasConstraintName("FK_EMPFMCHG_EMPLOYEE");
            });

            modelBuilder.Entity<EMPFRL>(entity =>
            {
                entity.HasIndex(e => new { e.FRL_DT, e.EMP_NO, e.CORP_NO, e.FRL_NO })
                    .HasName("EMPFRL_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.CORP_NO)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_SOURCE).HasMaxLength(1);

                entity.Property(e => e.EMP_NO)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.FRL_DT).HasColumnType("datetime");

                entity.Property(e => e.FRL_HR)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FRL_NO)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.REMK).HasMaxLength(255);
            });

            modelBuilder.Entity<EMPIJT>(entity =>
            {
                entity.HasIndex(e => new { e.EMP_NO, e.IJT_NO })
                    .HasName("EMPIJT_X1")
                    .IsUnique();

                entity.HasIndex(e => new { e.ID, e.PID })
                    .HasName("EMPIJT_X9")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ACC_NM).HasMaxLength(80);

                entity.Property(e => e.ACC_NO).HasMaxLength(80);

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.AMT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AMTED)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BANK_NO).HasMaxLength(10);

                entity.Property(e => e.CONTACTER).HasMaxLength(30);

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_CLS).HasMaxLength(1);

                entity.Property(e => e.C_DED_TY).HasMaxLength(1);

                entity.Property(e => e.C_PRO).HasMaxLength(1);

                entity.Property(e => e.C_SOURCE).HasMaxLength(1);

                entity.Property(e => e.DDT_DT).HasColumnType("datetime");

                entity.Property(e => e.DED_SR).HasMaxLength(10);

                entity.Property(e => e.DED_WT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DOC_NO).HasMaxLength(80);

                entity.Property(e => e.EMP_NO)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.FEE)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FEE_NO).HasMaxLength(10);

                entity.Property(e => e.IJT_DT).HasColumnType("datetime");

                entity.Property(e => e.IJT_NO)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.INT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MM_DED_AMT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.REMK).HasMaxLength(255);

                entity.Property(e => e.TEL_NO).HasMaxLength(20);

                entity.HasOne(d => d.P)
                    .WithMany(p => p.EMPIJT)
                    .HasForeignKey(d => d.PID)
                    .HasConstraintName("FK_EMPIJT_EMPLOYEE");
            });

            modelBuilder.Entity<EMPIMG>(entity =>
            {
                entity.HasIndex(e => e.GUID)
                    .HasName("EMPIMG_X1")
                    .IsUnique();

                entity.HasIndex(e => new { e.ID, e.PID })
                    .HasName("EMPIMG_X9")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.GUID)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<EMPISU>(entity =>
            {
                entity.HasIndex(e => new { e.ID, e.PID })
                    .HasName("EMPISU_X9")
                    .IsUnique();

                entity.HasIndex(e => new { e.EMP_NO, e.ISU_CORP_NO, e.ISU_NO, e.ISU_SLY })
                    .HasName("EMPISU_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.ADD_NO).HasMaxLength(10);

                entity.Property(e => e.ADD_RT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CORP_EXP)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_SOURCE).HasMaxLength(1);

                entity.Property(e => e.EMP_EXP)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EMP_NO)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ISU_CORP_NO)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.ISU_DT).HasColumnType("datetime");

                entity.Property(e => e.ISU_NO)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.ISU_SLY)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.REMK).HasMaxLength(255);

                entity.Property(e => e.RIS_DT).HasColumnType("datetime");

                entity.HasOne(d => d.P)
                    .WithMany(p => p.EMPISU)
                    .HasForeignKey(d => d.PID)
                    .HasConstraintName("FK_EMPISU_EMPLOYEE");
            });

            modelBuilder.Entity<EMPISUCHG>(entity =>
            {
                entity.HasIndex(e => new { e.ID, e.PID })
                    .HasName("EMPISUCHG_X9")
                    .IsUnique();

                entity.HasIndex(e => new { e.EMP_NO, e.CHG_DT, e.ISU_CORP_NO, e.ISU_NO })
                    .HasName("EMPISUCHG_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ADD_AMT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.ADD_NO).HasMaxLength(10);

                entity.Property(e => e.ADD_RT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AMT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CHG_DT).HasColumnType("datetime");

                entity.Property(e => e.CHG_TY).HasMaxLength(1);

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_CLS).HasMaxLength(1);

                entity.Property(e => e.C_SOURCE).HasMaxLength(1);

                entity.Property(e => e.EMP_NO)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.GRD).HasDefaultValueSql("0");

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ISU_CORP_NO)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.ISU_NO)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.REMK).HasMaxLength(255);

                entity.HasOne(d => d.P)
                    .WithMany(p => p.EMPISUCHG)
                    .HasForeignKey(d => d.PID)
                    .HasConstraintName("FK_EMPISUCHG_EMPLOYEE");
            });

            modelBuilder.Entity<EMPLOYEE>(entity =>
            {
                entity.HasIndex(e => e.EMP_NO)
                    .HasName("EMPLOYEE_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ACC_ID_NO).HasMaxLength(20);

                entity.Property(e => e.ACC_NM).HasMaxLength(80);

                entity.Property(e => e.ACC_NO).HasMaxLength(80);

                entity.Property(e => e.ADDR_MAL).HasMaxLength(80);

                entity.Property(e => e.ADDR_RGS).HasMaxLength(80);

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.ARV_DT).HasColumnType("datetime");

                entity.Property(e => e.ATTR).HasDefaultValueSql("0");

                entity.Property(e => e.BANK_ID).HasMaxLength(10);

                entity.Property(e => e.BANK_NO).HasMaxLength(10);

                entity.Property(e => e.BLOOD).HasMaxLength(10);

                entity.Property(e => e.BRD_DT).HasColumnType("datetime");

                entity.Property(e => e.CHK_DT).HasColumnType("datetime");

                entity.Property(e => e.CONTACTER).HasMaxLength(30);

                entity.Property(e => e.CON_TEL_NO).HasMaxLength(20);

                entity.Property(e => e.CORP_NO).HasMaxLength(10);

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_PAY_TY).HasMaxLength(1);

                entity.Property(e => e.C_SAL_TY).HasMaxLength(1);

                entity.Property(e => e.C_STA).HasMaxLength(1);

                entity.Property(e => e.DEPM_NO).HasMaxLength(10);

                entity.Property(e => e.DW_PRD).HasMaxLength(10);

                entity.Property(e => e.EDU_NO).HasMaxLength(20);

                entity.Property(e => e.EMP_NM).HasMaxLength(20);

                entity.Property(e => e.EMP_NO)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.ETR_DT).HasColumnType("datetime");

                entity.Property(e => e.E_MAIL).HasMaxLength(80);

                entity.Property(e => e.ID_NO).HasMaxLength(20);

                entity.Property(e => e.IJT_RT).HasColumnType("decimal");

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ISU_DT).HasColumnType("datetime");

                entity.Property(e => e.JOB_NO).HasMaxLength(10);

                entity.Property(e => e.JOB_RK).HasMaxLength(10);

                entity.Property(e => e.JOB_TITLE).HasMaxLength(10);

                entity.Property(e => e.LAB_WYR_DD).HasDefaultValueSql("0");

                entity.Property(e => e.LAB_WYR_YY).HasDefaultValueSql("0");

                entity.Property(e => e.LEV_DT).HasColumnType("datetime");

                entity.Property(e => e.LEV_NO).HasMaxLength(20);

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MJR_NO).HasMaxLength(20);

                entity.Property(e => e.MRD).HasMaxLength(1);

                entity.Property(e => e.OEMP_NO).HasMaxLength(10);

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RELA).HasMaxLength(20);

                entity.Property(e => e.REMK).HasMaxLength(255);

                entity.Property(e => e.RIS_DT).HasColumnType("datetime");

                entity.Property(e => e.RSU_DT).HasColumnType("datetime");

                entity.Property(e => e.RTN_DT).HasColumnType("datetime");

                entity.Property(e => e.SCH_NO).HasMaxLength(20);

                entity.Property(e => e.SER_NO).HasMaxLength(10);

                entity.Property(e => e.SEX).HasMaxLength(1);

                entity.Property(e => e.SLV_NO).HasMaxLength(10);

                entity.Property(e => e.SPS_DT).HasColumnType("datetime");

                entity.Property(e => e.TEL_NO).HasMaxLength(20);

                entity.Property(e => e.TEL_NO2).HasMaxLength(20);

                entity.Property(e => e.TEL_NO3).HasMaxLength(20);

                entity.Property(e => e.WYR_DT).HasColumnType("datetime");

                entity.Property(e => e.ZNO_MAL).HasMaxLength(10);

                entity.Property(e => e.ZNO_RGS).HasMaxLength(10);
            });

            modelBuilder.Entity<EMPPAYACT>(entity =>
            {
                entity.HasIndex(e => new { e.PID, e.ID })
                    .HasName("EMPPAYACT_X9")
                    .IsUnique();

                entity.HasIndex(e => new { e.YYYYMM, e.EMP_NO, e.CORP_NO, e.SR })
                    .HasName("EMPPAYACT_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ACT_EMP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ACT_NO)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.AMT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BCH_NO)
                    .HasMaxLength(24)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CN_NO)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CORP_NO)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CS_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_DCR).HasDefaultValueSql("0");

                entity.Property(e => e.C_PRD)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.DEPM_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.EMP_NO)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PID).HasDefaultValueSql("newid()");

                entity.Property(e => e.REMK)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SER_CORP_NO).HasMaxLength(10);

                entity.Property(e => e.SER_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SR).HasDefaultValueSql("0");

                entity.Property(e => e.YYYYMM)
                    .IsRequired()
                    .HasMaxLength(6)
                    .HasDefaultValueSql("''");

                entity.HasOne(d => d.P)
                    .WithMany(p => p.EMPPAYACT)
                    .HasForeignKey(d => d.PID)
                    .HasConstraintName("FK_EMPPAYAC_EMPPAYMT");
            });

            modelBuilder.Entity<EMPPAYACT_LOG>(entity =>
            {
                entity.HasKey(e => e.LogId)
                    .HasName("PK_EMPPAYACT_LOG");

                entity.Property(e => e.ACT_EMP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ACT_NO)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.AMT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BCH_NO)
                    .HasMaxLength(24)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CHG_COMPUTER_NAME).HasMaxLength(60);

                entity.Property(e => e.CHG_DATE).HasColumnType("datetime");

                entity.Property(e => e.CHG_DB_ROLE).HasMaxLength(60);

                entity.Property(e => e.CHG_DB_USER).HasMaxLength(60);

                entity.Property(e => e.CHG_TYPE).HasMaxLength(2);

                entity.Property(e => e.CHG_USER).HasMaxLength(60);

                entity.Property(e => e.CN_NO)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CORP_NO)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CS_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_DCR).HasDefaultValueSql("0");

                entity.Property(e => e.C_PRD)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.DEPM_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.EMP_NO)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PID).HasDefaultValueSql("newid()");

                entity.Property(e => e.REMK)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SER_CORP_NO).HasMaxLength(10);

                entity.Property(e => e.SER_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SR).HasDefaultValueSql("0");

                entity.Property(e => e.YYYYMM)
                    .IsRequired()
                    .HasMaxLength(6)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<EMPPAYAJS>(entity =>
            {
                entity.HasIndex(e => new { e.PID, e.ID })
                    .HasName("EMPPAYAJS_X9")
                    .IsUnique();

                entity.HasIndex(e => new { e.YYYYMM, e.EMP_NO, e.CORP_NO, e.SR })
                    .HasName("EMPPAYAJS_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.AJS_DT).HasColumnType("datetime");

                entity.Property(e => e.AJS_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.AVCH_DT).HasColumnType("datetime");

                entity.Property(e => e.AVCH_NO)
                    .HasMaxLength(15)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.AVCH_TY)
                    .HasMaxLength(4)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CORP_NO)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.EMP_NO)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PID).HasDefaultValueSql("newid()");

                entity.Property(e => e.SER_CORP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SR).HasDefaultValueSql("0");

                entity.Property(e => e.YYYYMM)
                    .IsRequired()
                    .HasMaxLength(6)
                    .HasDefaultValueSql("''");

                entity.HasOne(d => d.P)
                    .WithMany(p => p.EMPPAYAJS)
                    .HasForeignKey(d => d.PID)
                    .HasConstraintName("FK_EMPPAYAJ_EMPPAYMT");
            });

            modelBuilder.Entity<EMPPAYAJS_LOG>(entity =>
            {
                entity.HasKey(e => e.LogId)
                    .HasName("PK_EMPPAYAJS_LOG");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.AJS_DT).HasColumnType("datetime");

                entity.Property(e => e.AJS_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.AVCH_DT).HasColumnType("datetime");

                entity.Property(e => e.AVCH_NO)
                    .HasMaxLength(15)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.AVCH_TY)
                    .HasMaxLength(4)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CHG_COMPUTER_NAME).HasMaxLength(60);

                entity.Property(e => e.CHG_DATE).HasColumnType("datetime");

                entity.Property(e => e.CHG_DB_ROLE).HasMaxLength(60);

                entity.Property(e => e.CHG_DB_USER).HasMaxLength(60);

                entity.Property(e => e.CHG_TYPE).HasMaxLength(2);

                entity.Property(e => e.CHG_USER).HasMaxLength(60);

                entity.Property(e => e.CORP_NO)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.EMP_NO)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PID).HasDefaultValueSql("newid()");

                entity.Property(e => e.SER_CORP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SR).HasDefaultValueSql("0");

                entity.Property(e => e.YYYYMM)
                    .IsRequired()
                    .HasMaxLength(6)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<EMPPAYDL>(entity =>
            {
                entity.HasIndex(e => new { e.ID, e.PID })
                    .HasName("EMPPAYDL_X9")
                    .IsUnique();

                entity.HasIndex(e => new { e.YYYYMM, e.EMP_NO, e.CORP_NO, e.C_PRD, e.PMS_NO })
                    .HasName("EMPPAYDL_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.AMT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CORP_NO)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_CST).HasMaxLength(1);

                entity.Property(e => e.C_PRD)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.C_SOURCE).HasMaxLength(1);

                entity.Property(e => e.C_TAX).HasMaxLength(1);

                entity.Property(e => e.EMP_NO)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.IO).HasDefaultValueSql("1");

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PMS_NO)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.REMK).HasMaxLength(255);

                entity.Property(e => e.YYYYMM)
                    .IsRequired()
                    .HasMaxLength(6);

                entity.HasOne(d => d.P)
                    .WithMany(p => p.EMPPAYDL)
                    .HasForeignKey(d => d.PID)
                    .HasConstraintName("FK_EMPPAYDL_EMPPAYMT");
            });

            modelBuilder.Entity<EMPPAYDL_LOG>(entity =>
            {
                entity.HasKey(e => e.LogId)
                    .HasName("PK_EMPPAYDL_LOG");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.AMT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CHG_COMPUTER_NAME).HasMaxLength(60);

                entity.Property(e => e.CHG_DATE).HasColumnType("datetime");

                entity.Property(e => e.CHG_DB_ROLE).HasMaxLength(60);

                entity.Property(e => e.CHG_DB_USER).HasMaxLength(60);

                entity.Property(e => e.CHG_TYPE).HasMaxLength(2);

                entity.Property(e => e.CHG_USER).HasMaxLength(60);

                entity.Property(e => e.CORP_NO)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_CST).HasMaxLength(1);

                entity.Property(e => e.C_PRD)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.C_SOURCE).HasMaxLength(1);

                entity.Property(e => e.C_TAX).HasMaxLength(1);

                entity.Property(e => e.EMP_NO)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.IO).HasDefaultValueSql("1");

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PMS_NO)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.REMK).HasMaxLength(255);

                entity.Property(e => e.YYYYMM)
                    .IsRequired()
                    .HasMaxLength(6);
            });

            modelBuilder.Entity<EMPPAYDPC>(entity =>
            {
                entity.HasIndex(e => new { e.PID, e.ID })
                    .HasName("EMPPAYDPC_X9");

                entity.HasIndex(e => new { e.YYYYMM, e.EMP_NO, e.CORP_NO, e.CN_NO, e.SER_NO })
                    .HasName("EMPPAYDPC_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.AMT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CN_NO)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CORP_NO)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_SOURCE)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.EMP_NO)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PID).HasDefaultValueSql("newid()");

                entity.Property(e => e.REMK)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SER_NO)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.WRK_HR)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.YYYYMM)
                    .IsRequired()
                    .HasMaxLength(6)
                    .HasDefaultValueSql("''");

                entity.HasOne(d => d.P)
                    .WithMany(p => p.EMPPAYDPC)
                    .HasForeignKey(d => d.PID)
                    .HasConstraintName("FK_EMPPAYDPC_EMPPAYMT");
            });

            modelBuilder.Entity<EMPPAYDPC_LOG>(entity =>
            {
                entity.HasKey(e => e.LogId)
                    .HasName("PK_EMPPAYDPC_LOG");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.AMT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CHG_COMPUTER_NAME).HasMaxLength(60);

                entity.Property(e => e.CHG_DATE).HasColumnType("datetime");

                entity.Property(e => e.CHG_DB_ROLE).HasMaxLength(60);

                entity.Property(e => e.CHG_DB_USER).HasMaxLength(60);

                entity.Property(e => e.CHG_TYPE).HasMaxLength(2);

                entity.Property(e => e.CHG_USER).HasMaxLength(60);

                entity.Property(e => e.CN_NO)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CORP_NO)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_SOURCE)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.EMP_NO)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PID).HasDefaultValueSql("newid()");

                entity.Property(e => e.REMK)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SER_NO)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.WRK_HR)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.YYYYMM)
                    .IsRequired()
                    .HasMaxLength(6)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<EMPPAYDRAW>(entity =>
            {
                entity.HasIndex(e => new { e.YYYYMM, e.EMP_NO, e.CORP_NO, e.DRAW_NO })
                    .HasName("EMPPAYDRAW_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.AMT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CORP_NO)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_PRD).HasMaxLength(1);

                entity.Property(e => e.C_SOURCE).HasMaxLength(1);

                entity.Property(e => e.DRAW_DT).HasColumnType("datetime");

                entity.Property(e => e.DRAW_NO)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.EMP_NO)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PMS_NO).HasMaxLength(10);

                entity.Property(e => e.REMK).HasMaxLength(255);

                entity.Property(e => e.YYYYMM)
                    .IsRequired()
                    .HasMaxLength(6);

                entity.HasOne(d => d.P)
                    .WithMany(p => p.EMPPAYDRAW)
                    .HasForeignKey(d => d.PID)
                    .HasConstraintName("FK_EMPPAYDRAW_EMPPAYMT");
            });

            modelBuilder.Entity<EMPPAYDRAW_LOG>(entity =>
            {
                entity.HasKey(e => e.LogId)
                    .HasName("PK_EMPPAYDRAW_LOG");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.AMT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CHG_COMPUTER_NAME).HasMaxLength(60);

                entity.Property(e => e.CHG_DATE).HasColumnType("datetime");

                entity.Property(e => e.CHG_DB_ROLE).HasMaxLength(60);

                entity.Property(e => e.CHG_DB_USER).HasMaxLength(60);

                entity.Property(e => e.CHG_TYPE).HasMaxLength(2);

                entity.Property(e => e.CHG_USER).HasMaxLength(60);

                entity.Property(e => e.CORP_NO)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_PRD).HasMaxLength(1);

                entity.Property(e => e.C_SOURCE).HasMaxLength(1);

                entity.Property(e => e.DRAW_DT).HasColumnType("datetime");

                entity.Property(e => e.DRAW_NO)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.EMP_NO)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PMS_NO).HasMaxLength(10);

                entity.Property(e => e.REMK).HasMaxLength(255);

                entity.Property(e => e.YYYYMM)
                    .IsRequired()
                    .HasMaxLength(6);
            });

            modelBuilder.Entity<EMPPAYEQUIP>(entity =>
            {
                entity.HasIndex(e => new { e.ID, e.PID })
                    .HasName("EMPPAYEQUIP_X9")
                    .IsUnique();

                entity.HasIndex(e => new { e.YYYYMM, e.EMP_NO, e.CORP_NO, e.EQUIP_NO, e.ISS_DT })
                    .HasName("EMPPAYEQUIP_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.AMT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CORP_NO)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_SOURCE).HasMaxLength(1);

                entity.Property(e => e.EMP_NO)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.EQUIP_NO)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ISS_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.REMK).HasMaxLength(255);

                entity.Property(e => e.YYYYMM)
                    .IsRequired()
                    .HasMaxLength(6);

                entity.HasOne(d => d.P)
                    .WithMany(p => p.EMPPAYEQUIP)
                    .HasForeignKey(d => d.PID)
                    .HasConstraintName("FK_EMPPAYEQUIP_EMPPAYMT");
            });

            modelBuilder.Entity<EMPPAYEQUIP_LOG>(entity =>
            {
                entity.HasKey(e => e.LogId)
                    .HasName("PK_EMPPAYEQUIP_LOG");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.AMT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CHG_COMPUTER_NAME).HasMaxLength(60);

                entity.Property(e => e.CHG_DATE).HasColumnType("datetime");

                entity.Property(e => e.CHG_DB_ROLE).HasMaxLength(60);

                entity.Property(e => e.CHG_DB_USER).HasMaxLength(60);

                entity.Property(e => e.CHG_TYPE).HasMaxLength(2);

                entity.Property(e => e.CHG_USER).HasMaxLength(60);

                entity.Property(e => e.CORP_NO)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_SOURCE).HasMaxLength(1);

                entity.Property(e => e.EMP_NO)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.EQUIP_NO)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ISS_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.REMK).HasMaxLength(255);

                entity.Property(e => e.YYYYMM)
                    .IsRequired()
                    .HasMaxLength(6);
            });

            modelBuilder.Entity<EMPPAYFM>(entity =>
            {
                entity.HasIndex(e => new { e.ID, e.PID })
                    .HasName("EMPPAYFM_X9")
                    .IsUnique();

                entity.HasIndex(e => new { e.YYYYMM, e.EMP_NO, e.CORP_NO, e.ID_NO })
                    .HasName("EMPPAYFM_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.ADD_NO).HasMaxLength(10);

                entity.Property(e => e.ADD_RT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BRD_DT).HasColumnType("datetime");

                entity.Property(e => e.CORP_NO)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_ISU).HasMaxLength(1);

                entity.Property(e => e.C_SOURCE).HasMaxLength(1);

                entity.Property(e => e.EMP_NO)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.FA_NM).HasMaxLength(20);

                entity.Property(e => e.ID_NO)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ISU_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RELA).HasMaxLength(20);

                entity.Property(e => e.REMK).HasMaxLength(255);

                entity.Property(e => e.RIS_DT).HasColumnType("datetime");

                entity.Property(e => e.YYYYMM)
                    .IsRequired()
                    .HasMaxLength(6);

                entity.HasOne(d => d.P)
                    .WithMany(p => p.EMPPAYFM)
                    .HasForeignKey(d => d.PID)
                    .HasConstraintName("FK_EMPPAYFM_EMPPAYMT");
            });

            modelBuilder.Entity<EMPPAYFM_LOG>(entity =>
            {
                entity.HasKey(e => e.LogId)
                    .HasName("PK_EMPPAYFM_LOG");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.ADD_NO).HasMaxLength(10);

                entity.Property(e => e.ADD_RT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BRD_DT).HasColumnType("datetime");

                entity.Property(e => e.CHG_COMPUTER_NAME).HasMaxLength(60);

                entity.Property(e => e.CHG_DATE).HasColumnType("datetime");

                entity.Property(e => e.CHG_DB_ROLE).HasMaxLength(60);

                entity.Property(e => e.CHG_DB_USER).HasMaxLength(60);

                entity.Property(e => e.CHG_TYPE).HasMaxLength(2);

                entity.Property(e => e.CHG_USER).HasMaxLength(60);

                entity.Property(e => e.CORP_NO)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_ISU).HasMaxLength(1);

                entity.Property(e => e.C_SOURCE).HasMaxLength(1);

                entity.Property(e => e.EMP_NO)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.FA_NM).HasMaxLength(20);

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ID_NO)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ISU_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RELA).HasMaxLength(20);

                entity.Property(e => e.REMK).HasMaxLength(255);

                entity.Property(e => e.RIS_DT).HasColumnType("datetime");

                entity.Property(e => e.YYYYMM)
                    .IsRequired()
                    .HasMaxLength(6);
            });

            modelBuilder.Entity<EMPPAYFRL>(entity =>
            {
                entity.HasIndex(e => new { e.ID, e.PID })
                    .HasName("EMPPAYFRL_X9")
                    .IsUnique();

                entity.HasIndex(e => new { e.YYYYMM, e.EMP_NO, e.CORP_NO, e.FRL_NO })
                    .HasName("EMPPAYFRL_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.CORP_NO)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_SOURCE).HasMaxLength(1);

                entity.Property(e => e.DDT_HR)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DDT_RT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EMP_NO)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.FRL_HR)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FRL_NO)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.REMK).HasMaxLength(255);

                entity.Property(e => e.YYYYMM)
                    .IsRequired()
                    .HasMaxLength(6);

                entity.HasOne(d => d.P)
                    .WithMany(p => p.EMPPAYFRL)
                    .HasForeignKey(d => d.PID)
                    .HasConstraintName("FK_EMPPAYFRL_EMPPAYMT");
            });

            modelBuilder.Entity<EMPPAYFRL_LOG>(entity =>
            {
                entity.HasKey(e => e.LogId)
                    .HasName("PK_EMPPAYFRL_LOG");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.CHG_COMPUTER_NAME).HasMaxLength(60);

                entity.Property(e => e.CHG_DATE).HasColumnType("datetime");

                entity.Property(e => e.CHG_DB_ROLE).HasMaxLength(60);

                entity.Property(e => e.CHG_DB_USER).HasMaxLength(60);

                entity.Property(e => e.CHG_TYPE).HasMaxLength(2);

                entity.Property(e => e.CHG_USER).HasMaxLength(60);

                entity.Property(e => e.CORP_NO)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_SOURCE).HasMaxLength(1);

                entity.Property(e => e.DDT_HR)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DDT_RT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EMP_NO)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.FRL_HR)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FRL_NO)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.REMK).HasMaxLength(255);

                entity.Property(e => e.YYYYMM)
                    .IsRequired()
                    .HasMaxLength(6);
            });

            modelBuilder.Entity<EMPPAYIJT>(entity =>
            {
                entity.HasIndex(e => new { e.PID, e.ID })
                    .HasName("EMPPAYIJT_X9")
                    .IsUnique();

                entity.HasIndex(e => new { e.YYYYMM, e.EMP_NO, e.CORP_NO, e.IJT_NO })
                    .HasName("EMPPAYIJT_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.AMT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CORP_NO)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_SOURCE)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.EMP_NO)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.FEE)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IJT_DT).HasColumnType("datetime");

                entity.Property(e => e.IJT_NO)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PID).HasDefaultValueSql("newid()");

                entity.Property(e => e.REMK)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.YYYYMM)
                    .IsRequired()
                    .HasMaxLength(6)
                    .HasDefaultValueSql("''");

                entity.HasOne(d => d.P)
                    .WithMany(p => p.EMPPAYIJT)
                    .HasForeignKey(d => d.PID)
                    .HasConstraintName("FK_EMPPAYIJT_EMPPAYMT");
            });

            modelBuilder.Entity<EMPPAYIJT_LOG>(entity =>
            {
                entity.HasKey(e => e.LogId)
                    .HasName("PK_EMPPAYIJT_LOG");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.AMT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CHG_COMPUTER_NAME).HasMaxLength(60);

                entity.Property(e => e.CHG_DATE).HasColumnType("datetime");

                entity.Property(e => e.CHG_DB_ROLE).HasMaxLength(60);

                entity.Property(e => e.CHG_DB_USER).HasMaxLength(60);

                entity.Property(e => e.CHG_TYPE).HasMaxLength(2);

                entity.Property(e => e.CHG_USER).HasMaxLength(60);

                entity.Property(e => e.CORP_NO)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_SOURCE)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.EMP_NO)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.FEE)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.IJT_DT).HasColumnType("datetime");

                entity.Property(e => e.IJT_NO)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PID).HasDefaultValueSql("newid()");

                entity.Property(e => e.REMK)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.YYYYMM)
                    .IsRequired()
                    .HasMaxLength(6)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<EMPPAYISU>(entity =>
            {
                entity.HasIndex(e => new { e.ID, e.PID })
                    .HasName("EMPPAYISU_X9")
                    .IsUnique();

                entity.HasIndex(e => new { e.YYYYMM, e.EMP_NO, e.CORP_NO, e.ISU_CORP_NO, e.ISU_NO, e.ISU_SLY })
                    .HasName("EMPPAYISU_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.ADD_EXP)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ADD_NO).HasMaxLength(10);

                entity.Property(e => e.ADD_RT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CORP_EXP)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CORP_NO)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.CORP_PNS)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_SOURCE).HasMaxLength(1);

                entity.Property(e => e.EMP_EXP)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EMP_NO)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.EMP_PNS)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FM_ADD_RT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FM_EXP).HasColumnType("decimal");

                entity.Property(e => e.FM_MS).HasDefaultValueSql("0");

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ISU_CORP_NO)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.ISU_DT).HasColumnType("datetime");

                entity.Property(e => e.ISU_NO)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.ISU_SLY)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PT_DAY).HasDefaultValueSql("0");

                entity.Property(e => e.REMK).HasMaxLength(255);

                entity.Property(e => e.RIS_DT).HasColumnType("datetime");

                entity.Property(e => e.YYYYMM)
                    .IsRequired()
                    .HasMaxLength(6);

                entity.HasOne(d => d.P)
                    .WithMany(p => p.EMPPAYISU)
                    .HasForeignKey(d => d.PID)
                    .HasConstraintName("FK_EMPPAYISU_EMPPAYMT");
            });

            modelBuilder.Entity<EMPPAYISU_LOG>(entity =>
            {
                entity.HasKey(e => e.LogId)
                    .HasName("PK_EMPPAYISU_LOG");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.ADD_EXP)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ADD_NO).HasMaxLength(10);

                entity.Property(e => e.ADD_RT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CHG_COMPUTER_NAME).HasMaxLength(60);

                entity.Property(e => e.CHG_DATE).HasColumnType("datetime");

                entity.Property(e => e.CHG_DB_ROLE).HasMaxLength(60);

                entity.Property(e => e.CHG_DB_USER).HasMaxLength(60);

                entity.Property(e => e.CHG_TYPE).HasMaxLength(2);

                entity.Property(e => e.CHG_USER).HasMaxLength(60);

                entity.Property(e => e.CORP_EXP)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CORP_NO)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.CORP_PNS)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_SOURCE).HasMaxLength(1);

                entity.Property(e => e.EMP_EXP)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EMP_NO)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.EMP_PNS)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FM_ADD_RT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FM_EXP).HasColumnType("decimal");

                entity.Property(e => e.FM_MS).HasDefaultValueSql("0");

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ISU_CORP_NO)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.ISU_DT).HasColumnType("datetime");

                entity.Property(e => e.ISU_NO)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.ISU_SLY)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PT_DAY).HasDefaultValueSql("0");

                entity.Property(e => e.REMK).HasMaxLength(255);

                entity.Property(e => e.RIS_DT).HasColumnType("datetime");

                entity.Property(e => e.YYYYMM)
                    .IsRequired()
                    .HasMaxLength(6);
            });

            modelBuilder.Entity<EMPPAYMT>(entity =>
            {
                entity.HasIndex(e => new { e.YYYYMM, e.EMP_NO, e.CORP_NO })
                    .HasName("EMPPAYMT_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.AMT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ARV_DT).HasColumnType("datetime");

                entity.Property(e => e.AVCH_NO).HasMaxLength(15);

                entity.Property(e => e.AVCH_TY).HasMaxLength(4);

                entity.Property(e => e.CFM_DT).HasColumnType("datetime");

                entity.Property(e => e.CFM_USR_NO).HasMaxLength(10);

                entity.Property(e => e.CORP_NO)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_AJS).HasMaxLength(1);

                entity.Property(e => e.C_CFM)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_SAL_TY).HasMaxLength(1);

                entity.Property(e => e.C_SOURCE).HasMaxLength(1);

                entity.Property(e => e.DCL_CORP_NO).HasMaxLength(10);

                entity.Property(e => e.DEPM_NO).HasMaxLength(10);

                entity.Property(e => e.EMP_NO)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.EXP_AMT).HasColumnType("decimal");

                entity.Property(e => e.HR_SLY)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.JOB_NO).HasMaxLength(10);

                entity.Property(e => e.LEV_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PT_DAY).HasDefaultValueSql("0");

                entity.Property(e => e.REMK).HasMaxLength(255);

                entity.Property(e => e.SER_NO).HasMaxLength(10);

                entity.Property(e => e.TAX_INC)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.YYYYMM)
                    .IsRequired()
                    .HasMaxLength(6);
            });

            modelBuilder.Entity<EMPPAYMT_LOG>(entity =>
            {
                entity.HasKey(e => e.LogId)
                    .HasName("PK_EMPPAYMT_LOG_1");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.AMT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ARV_DT).HasColumnType("datetime");

                entity.Property(e => e.AVCH_NO).HasMaxLength(15);

                entity.Property(e => e.AVCH_TY).HasMaxLength(4);

                entity.Property(e => e.CFM_DT).HasColumnType("datetime");

                entity.Property(e => e.CFM_USR_NO).HasMaxLength(10);

                entity.Property(e => e.CHG_COMPUTER_NAME).HasMaxLength(60);

                entity.Property(e => e.CHG_DATE).HasColumnType("datetime");

                entity.Property(e => e.CHG_DB_ROLE).HasMaxLength(60);

                entity.Property(e => e.CHG_DB_USER).HasMaxLength(60);

                entity.Property(e => e.CHG_TYPE).HasMaxLength(2);

                entity.Property(e => e.CHG_USER).HasMaxLength(60);

                entity.Property(e => e.CORP_NO)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_AJS).HasMaxLength(1);

                entity.Property(e => e.C_CFM)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_SAL_TY).HasMaxLength(1);

                entity.Property(e => e.C_SOURCE).HasMaxLength(1);

                entity.Property(e => e.DCL_CORP_NO).HasMaxLength(10);

                entity.Property(e => e.DEPM_NO).HasMaxLength(10);

                entity.Property(e => e.EMP_NO)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.EXP_AMT).HasColumnType("decimal");

                entity.Property(e => e.HR_SLY)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.JOB_NO).HasMaxLength(10);

                entity.Property(e => e.LEV_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PT_DAY).HasDefaultValueSql("0");

                entity.Property(e => e.REMK).HasMaxLength(255);

                entity.Property(e => e.SER_NO).HasMaxLength(10);

                entity.Property(e => e.TAX_INC)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.YYYYMM)
                    .IsRequired()
                    .HasMaxLength(6);
            });

            modelBuilder.Entity<EMPPAYOTH>(entity =>
            {
                entity.HasIndex(e => new { e.ID, e.PID })
                    .HasName("EMPPAYOTH_X9")
                    .IsUnique();

                entity.HasIndex(e => new { e.YYYYMM, e.EMP_NO, e.CORP_NO, e.C_PRD, e.PMS_NO })
                    .HasName("EMPPAYOTH_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.AMT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CORP_NO)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_PRD)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.C_SOURCE).HasMaxLength(1);

                entity.Property(e => e.EMP_NO)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PMS_NO)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.REMK).HasMaxLength(255);

                entity.Property(e => e.YYYYMM)
                    .IsRequired()
                    .HasMaxLength(6);

                entity.HasOne(d => d.P)
                    .WithMany(p => p.EMPPAYOTH)
                    .HasForeignKey(d => d.PID)
                    .HasConstraintName("FK_EMPPAYOTH_EMPPAYMT");
            });

            modelBuilder.Entity<EMPPAYOTH_LOG>(entity =>
            {
                entity.HasKey(e => e.LogId)
                    .HasName("PK_EMPPAYOTH_LOG");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.AMT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CHG_COMPUTER_NAME).HasMaxLength(60);

                entity.Property(e => e.CHG_DATE).HasColumnType("datetime");

                entity.Property(e => e.CHG_DB_ROLE).HasMaxLength(60);

                entity.Property(e => e.CHG_DB_USER).HasMaxLength(60);

                entity.Property(e => e.CHG_TYPE).HasMaxLength(2);

                entity.Property(e => e.CHG_USER).HasMaxLength(60);

                entity.Property(e => e.CORP_NO)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_PRD)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.C_SOURCE).HasMaxLength(1);

                entity.Property(e => e.EMP_NO)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PMS_NO)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.REMK).HasMaxLength(255);

                entity.Property(e => e.YYYYMM)
                    .IsRequired()
                    .HasMaxLength(6);
            });

            modelBuilder.Entity<EMPPAYWRK>(entity =>
            {
                entity.HasIndex(e => new { e.ID, e.PID })
                    .HasName("EMPPAYWRK_X9")
                    .IsUnique();

                entity.HasIndex(e => new { e.YYYYMM, e.EMP_NO, e.CORP_NO, e.CN_NO, e.SER_NO, e.JOB_NO, e.C_TY })
                    .HasName("EMPPAYWRK_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.CN_NO)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.CORP_NO)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_SOURCE).HasMaxLength(1);

                entity.Property(e => e.C_TY)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.EMP_NO)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.HR_SLY)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.JOB_NO)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.REMK).HasMaxLength(255);

                entity.Property(e => e.SER_CORP_NO).HasMaxLength(10);

                entity.Property(e => e.SER_NO)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.WRK_HR)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.YYYYMM)
                    .IsRequired()
                    .HasMaxLength(6);

                entity.HasOne(d => d.P)
                    .WithMany(p => p.EMPPAYWRK)
                    .HasForeignKey(d => d.PID)
                    .HasConstraintName("FK_EMPPAYWRK_EMPPAYMT");
            });

            modelBuilder.Entity<EMPPAYWRK_LOG>(entity =>
            {
                entity.HasKey(e => e.LogId)
                    .HasName("PK_EMPPAYWRK_LOG");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.CHG_COMPUTER_NAME).HasMaxLength(60);

                entity.Property(e => e.CHG_DATE).HasColumnType("datetime");

                entity.Property(e => e.CHG_DB_ROLE).HasMaxLength(60);

                entity.Property(e => e.CHG_DB_USER).HasMaxLength(60);

                entity.Property(e => e.CHG_TYPE).HasMaxLength(2);

                entity.Property(e => e.CHG_USER).HasMaxLength(60);

                entity.Property(e => e.CN_NO)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.CORP_NO)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_SOURCE).HasMaxLength(1);

                entity.Property(e => e.C_TY).HasMaxLength(1);

                entity.Property(e => e.EMP_NO)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.HR_SLY)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.JOB_NO)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.REMK).HasMaxLength(255);

                entity.Property(e => e.SER_CORP_NO).HasMaxLength(10);

                entity.Property(e => e.SER_NO)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.WRK_HR)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.YYYYMM)
                    .IsRequired()
                    .HasMaxLength(6);
            });

            modelBuilder.Entity<EMPPMS>(entity =>
            {
                entity.HasIndex(e => new { e.ID, e.PID })
                    .HasName("EMPPMS_X9")
                    .IsUnique();

                entity.HasIndex(e => new { e.EMP_NO, e.CORP_NO, e.PMS_NO, e.C_PRD })
                    .HasName("EMPPMS_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.AMT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CORP_NO)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_PRD)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.EMP_NO)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PMS_NO)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.REMK).HasMaxLength(255);

                entity.HasOne(d => d.P)
                    .WithMany(p => p.EMPPMS)
                    .HasForeignKey(d => d.PID)
                    .HasConstraintName("FK_EMPPMS_EMPLOYEE");
            });

            modelBuilder.Entity<EMPWRK>(entity =>
            {
                entity.HasIndex(e => new { e.WRK_DT, e.EMP_NO, e.CORP_NO, e.CN_NO, e.SER_NO, e.JOB_NO })
                    .HasName("EMPWRK_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.CN_NO)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.CORP_NO)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_CFM).HasMaxLength(1);

                entity.Property(e => e.C_SOURCE).HasMaxLength(1);

                entity.Property(e => e.EMP_NO)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.JOB_NO)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.REMK).HasMaxLength(255);

                entity.Property(e => e.SER_CORP_NO).HasMaxLength(10);

                entity.Property(e => e.SER_NO)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.WRK_DT).HasColumnType("datetime");

                entity.Property(e => e.WRK_HR)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<EQUIP>(entity =>
            {
                entity.HasIndex(e => e.EQUIP_NO)
                    .HasName("EQUIP_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.CP_NM).HasMaxLength(30);

                entity.Property(e => e.EQUIP_NM).HasMaxLength(60);

                entity.Property(e => e.EQUIP_NO)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.IP_NM).HasMaxLength(30);

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO).HasMaxLength(10);

                entity.Property(e => e.OWNER_GRP_NO).HasMaxLength(10);

                entity.Property(e => e.OWNER_USR_NO).HasMaxLength(10);

                entity.Property(e => e.PRC)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.REMK).HasMaxLength(255);

                entity.Property(e => e.UNIT).HasMaxLength(4);
            });

            modelBuilder.Entity<ErrorLog>(entity =>
            {
                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.Date).HasColumnType("datetime");
            });

            modelBuilder.Entity<FILEDL>(entity =>
            {
                entity.HasIndex(e => e.GUID)
                    .HasName("FILEDL_X1")
                    .IsUnique();

                entity.HasIndex(e => new { e.ID, e.PID })
                    .HasName("FILEDL_X9")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CREATETIME).HasColumnType("datetime");

                entity.Property(e => e.FILECONTENT).HasColumnType("image");

                entity.Property(e => e.FILEEXTNAME).HasMaxLength(10);

                entity.Property(e => e.FILELENGTH).HasDefaultValueSql("0");

                entity.Property(e => e.FILENAME).HasMaxLength(255);

                entity.Property(e => e.FILETYPE).HasMaxLength(30);

                entity.Property(e => e.FULLPATH).HasMaxLength(255);

                entity.Property(e => e.GUID)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.LASTWRITETIME).HasColumnType("datetime");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PATH).HasMaxLength(255);

                entity.HasOne(d => d.P)
                    .WithMany(p => p.FILEDL)
                    .HasForeignKey(d => d.PID)
                    .HasConstraintName("FK_FILEDL_FILEMT");
            });

            modelBuilder.Entity<FILEMT>(entity =>
            {
                entity.HasIndex(e => e.CLASS_NO)
                    .HasName("FILEMT_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.CLASS_NO)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.REMK).HasMaxLength(255);
            });

            modelBuilder.Entity<FRLNO>(entity =>
            {
                entity.HasIndex(e => e.FRL_NO)
                    .HasName("FRLNO_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_DDT).HasMaxLength(1);

                entity.Property(e => e.DDT_RT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FRL_NM).HasMaxLength(20);

                entity.Property(e => e.FRL_NO)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<GNRLGR>(entity =>
            {
                entity.HasIndex(e => new { e.VCH_TY, e.VCH_NO, e.VCH_SR })
                    .HasName("GNRLGR_X1")
                    .IsUnique();

                entity.HasIndex(e => new { e.CORP_NO, e.ACT_NO, e.VCH_DT, e.DEPM_NO, e.CN_NO, e.SER_NO, e.CS_NO })
                    .HasName("GNRLGR_X2");

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ACT_NO)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.AMT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BCH_NO)
                    .HasMaxLength(24)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CFW_NO)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CLS_DT).HasColumnType("datetime");

                entity.Property(e => e.CN_NO)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CORP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CS_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_CLS)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_DCR).HasDefaultValueSql("1");

                entity.Property(e => e.DEPM_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.EMP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ITEM_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PRC)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PRJ_NO)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.QTY)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.REMK)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SER_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SVCH_NO)
                    .HasMaxLength(15)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SVCH_SR).HasDefaultValueSql("0");

                entity.Property(e => e.SVCH_TY)
                    .HasMaxLength(4)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.VCH_DT).HasColumnType("datetime");

                entity.Property(e => e.VCH_NO)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.VCH_SR).HasDefaultValueSql("0");

                entity.Property(e => e.VCH_TY)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.VD_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<GRPNO>(entity =>
            {
                entity.HasIndex(e => e.GRP_NO)
                    .HasName("GRPNO_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.GRP_NM).HasMaxLength(20);

                entity.Property(e => e.GRP_NO)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<GRPPMS>(entity =>
            {
                entity.HasIndex(e => new { e.GRP_NO, e.PRG_NO })
                    .HasName("GRPPMS_X1")
                    .IsUnique();

                entity.HasIndex(e => new { e.ID, e.PID })
                    .HasName("GRPPMS_X9")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_ADD).HasColumnType("char(1)");

                entity.Property(e => e.C_ATT).HasColumnType("char(1)");

                entity.Property(e => e.C_CFM).HasColumnType("char(1)");

                entity.Property(e => e.C_CPY).HasColumnType("char(1)");

                entity.Property(e => e.C_CST).HasColumnType("char(1)");

                entity.Property(e => e.C_DEL).HasColumnType("char(1)");

                entity.Property(e => e.C_EML).HasColumnType("char(1)");

                entity.Property(e => e.C_MDY).HasColumnType("char(1)");

                entity.Property(e => e.C_QRY).HasColumnType("char(1)");

                entity.Property(e => e.C_RUN).HasColumnType("char(1)");

                entity.Property(e => e.C_SIN).HasColumnType("char(1)");

                entity.Property(e => e.C_UCF).HasColumnType("char(1)");

                entity.Property(e => e.GRP_NO)
                    .IsRequired()
                    .HasColumnType("char(10)");

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PRG_NO)
                    .IsRequired()
                    .HasColumnType("char(24)");

                entity.HasOne(d => d.P)
                    .WithMany(p => p.GRPPMS)
                    .HasForeignKey(d => d.PID)
                    .HasConstraintName("FK_GRPPMS_GRPNO");
            });

            modelBuilder.Entity<ISUADD>(entity =>
            {
                entity.HasIndex(e => e.ADD_NO)
                    .HasName("ISUADD_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.ADD_NM).HasMaxLength(20);

                entity.Property(e => e.ADD_NO)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.ADD_RT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CP_NM).HasMaxLength(30);

                entity.Property(e => e.IP_NM).HasMaxLength(30);

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO).HasMaxLength(10);

                entity.Property(e => e.OWNER_GRP_NO).HasMaxLength(10);

                entity.Property(e => e.OWNER_USR_NO).HasMaxLength(10);

                entity.Property(e => e.REMK).HasMaxLength(255);
            });

            modelBuilder.Entity<ISUGRD>(entity =>
            {
                entity.HasIndex(e => new { e.GRD_NO, e.GRD })
                    .HasName("ISUGRD_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.AMT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CP_NM).HasMaxLength(30);

                entity.Property(e => e.GRD).HasDefaultValueSql("0");

                entity.Property(e => e.GRD_NO)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.IP_NM).HasMaxLength(30);

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO).HasMaxLength(10);

                entity.Property(e => e.OWNER_GRP_NO).HasMaxLength(10);

                entity.Property(e => e.OWNER_USR_NO).HasMaxLength(10);
            });

            modelBuilder.Entity<ISUID>(entity =>
            {
                entity.HasIndex(e => e.ISU_NO)
                    .HasName("ISUID_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CR_ACT_NO).HasMaxLength(20);

                entity.Property(e => e.C_DEPM_CR).HasMaxLength(1);

                entity.Property(e => e.C_DEPM_DR).HasMaxLength(1);

                entity.Property(e => e.C_EMP_CR).HasMaxLength(1);

                entity.Property(e => e.C_EMP_DR).HasMaxLength(1);

                entity.Property(e => e.C_PRD).HasMaxLength(1);

                entity.Property(e => e.C_PT_TY).HasMaxLength(1);

                entity.Property(e => e.DR_ACT_NO).HasMaxLength(20);

                entity.Property(e => e.EXP_RT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.GRD_NO).HasMaxLength(10);

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ISU_NM).HasMaxLength(20);

                entity.Property(e => e.ISU_NO)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.ISU_TY).HasMaxLength(10);

                entity.Property(e => e.MAX_GRD).HasDefaultValueSql("0");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PMS_NO).HasMaxLength(10);

                entity.Property(e => e.REMK).HasMaxLength(255);

                entity.Property(e => e.YEE_RT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.YER_RT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<IVCCNAR>(entity =>
            {
                entity.HasIndex(e => new { e.PID, e.ID })
                    .HasName("IVCCNAR_X9")
                    .IsUnique();

                entity.HasIndex(e => new { e.VCH_TY, e.VCH_NO, e.VCH_SR })
                    .HasName("IVCCNAR_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.AR_NO)
                    .HasMaxLength(15)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.AR_SR).HasDefaultValueSql("0");

                entity.Property(e => e.AR_TY)
                    .HasMaxLength(4)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_SOURCE).HasMaxLength(1);

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IVC_AMT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IVC_TAX)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PID).HasDefaultValueSql("newid()");

                entity.Property(e => e.REMK)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.VCH_NO)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.VCH_SR).HasDefaultValueSql("0");

                entity.Property(e => e.VCH_TY)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasDefaultValueSql("''");

                entity.HasOne(d => d.P)
                    .WithMany(p => p.IVCCNAR)
                    .HasForeignKey(d => d.PID)
                    .HasConstraintName("FK_IVCCNAR_IVCCNMT");
            });

            modelBuilder.Entity<IVCCNDL>(entity =>
            {
                entity.HasIndex(e => new { e.PID, e.ID })
                    .HasName("IVCCNDL_X9")
                    .IsUnique();

                entity.HasIndex(e => new { e.VCH_TY, e.VCH_NO, e.VCH_SR })
                    .HasName("IVCCNDL_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.AMT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.B_DT).HasColumnType("datetime");

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.E_DT).HasColumnType("datetime");

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PID).HasDefaultValueSql("newid()");

                entity.Property(e => e.PRC)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.QTY)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.REMK)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.UNIT).HasMaxLength(4);

                entity.Property(e => e.VCH_NO)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.VCH_SR).HasDefaultValueSql("0");

                entity.Property(e => e.VCH_TY)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.VITEM_NM)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.VITEM_NO)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.HasOne(d => d.P)
                    .WithMany(p => p.IVCCNDL)
                    .HasForeignKey(d => d.PID)
                    .HasConstraintName("FK_IVCCNDL_IVCCNMT");
            });

            modelBuilder.Entity<IVCCNMT>(entity =>
            {
                entity.HasIndex(e => new { e.VCH_TY, e.VCH_NO })
                    .HasName("IVCCNMT_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.B_UNIQUE_NO)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CFM_DT).HasColumnType("datetime");

                entity.Property(e => e.CFM_USR_NO).HasMaxLength(10);

                entity.Property(e => e.CORP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CS_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_CFM)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_SIGN)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_SOURCE)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.FULL_NM)
                    .HasMaxLength(80)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IVC_AMT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IVC_DT).HasColumnType("datetime");

                entity.Property(e => e.IVC_GRP)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IVC_NO)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IVC_PAGE)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IVC_TAX)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.N_PRT).HasDefaultValueSql("0");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.REMK)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.S_UNIQUE_NO)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TAX_RT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TAX_TY)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.VCH_DT).HasColumnType("datetime");

                entity.Property(e => e.VCH_NO)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.VCH_TY)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.YYYYMM)
                    .HasMaxLength(6)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<IVCGRP>(entity =>
            {
                entity.HasIndex(e => e.IVC_GRP)
                    .HasName("IVCGRP_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.GRP_NM)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IVC_GRP)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.REMK)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<IVCMM>(entity =>
            {
                entity.HasIndex(e => new { e.YYYYMM, e.IVC_GRP })
                    .HasName("IVCMM_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.CORP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_DEPM)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_USR)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_VCH)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IVC_GRP)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IVC_NO)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IVC_NO_E)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IVC_PAGE).HasMaxLength(1);

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.REMK)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.UNIQUE_NO)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.YYYYMM)
                    .IsRequired()
                    .HasMaxLength(6)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.YYYYMM_E)
                    .HasMaxLength(6)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<IVCMMDEPM>(entity =>
            {
                entity.HasIndex(e => new { e.PID, e.ID })
                    .HasName("IVCMMDEPM_X9")
                    .IsUnique();

                entity.HasIndex(e => new { e.YYYYMM, e.IVC_GRP, e.DEPM_NO })
                    .HasName("IVCMMDEPM_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.DEPM_NO)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IVC_GRP)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PID).HasDefaultValueSql("newid()");

                entity.Property(e => e.REMK)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.YYYYMM)
                    .IsRequired()
                    .HasMaxLength(6)
                    .HasDefaultValueSql("''");

                entity.HasOne(d => d.P)
                    .WithMany(p => p.IVCMMDEPM)
                    .HasForeignKey(d => d.PID)
                    .HasConstraintName("FK_IVCMMDEP_IVCMM");
            });

            modelBuilder.Entity<IVCMMUSR>(entity =>
            {
                entity.HasIndex(e => new { e.PID, e.ID })
                    .HasName("IVCMMUSR_X9")
                    .IsUnique();

                entity.HasIndex(e => new { e.YYYYMM, e.IVC_GRP, e.USR_NO })
                    .HasName("IVCMMUSR_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IVC_GRP)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PID).HasDefaultValueSql("newid()");

                entity.Property(e => e.REMK)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.USR_NO)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.YYYYMM)
                    .IsRequired()
                    .HasMaxLength(6)
                    .HasDefaultValueSql("''");

                entity.HasOne(d => d.P)
                    .WithMany(p => p.IVCMMUSR)
                    .HasForeignKey(d => d.PID)
                    .HasConstraintName("FK_IVCMMUSR_IVCMM");
            });

            modelBuilder.Entity<IVCMMVCH>(entity =>
            {
                entity.HasIndex(e => new { e.PID, e.ID })
                    .HasName("IVCMMVCH_X9")
                    .IsUnique();

                entity.HasIndex(e => new { e.YYYYMM, e.IVC_GRP, e.VCH_TY })
                    .HasName("IVCMMVCH_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IVC_GRP)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PID).HasDefaultValueSql("newid()");

                entity.Property(e => e.REMK)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.VCH_TY)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.YYYYMM)
                    .IsRequired()
                    .HasMaxLength(6)
                    .HasDefaultValueSql("''");

                entity.HasOne(d => d.P)
                    .WithMany(p => p.IVCMMVCH)
                    .HasForeignKey(d => d.PID)
                    .HasConstraintName("FK_IVCMMVCH_IVCMM");
            });

            modelBuilder.Entity<JOB>(entity =>
            {
                entity.HasIndex(e => e.JOB_NO)
                    .HasName("JOB_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_TY).HasMaxLength(1);

                entity.Property(e => e.HR_SLY).HasColumnType("decimal");

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.JOB_NM)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.JOB_NO)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.REMK)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<MDMBANK>(entity =>
            {
                entity.HasIndex(e => new { e.BANK_NO, e.C_TY, e.SR_NO })
                    .HasName("MDMBANK_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.BANK_NO)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_CTL)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_TY)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.FIX_CHAR)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.FLD_NM)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.FLD_TITLE)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.LENGTH).HasDefaultValueSql("0");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.REMK)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SR_NO).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<MENU>(entity =>
            {
                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.CP_NM).HasMaxLength(30);

                entity.Property(e => e.IP_NM).HasMaxLength(30);

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO).HasMaxLength(10);

                entity.Property(e => e.OWNER_GRP_NO).HasMaxLength(10);

                entity.Property(e => e.OWNER_USR_NO).HasMaxLength(10);

                entity.Property(e => e.PRG_NO)
                    .IsRequired()
                    .HasMaxLength(24);

                entity.Property(e => e.PRG_SR).HasDefaultValueSql("0");

                entity.Property(e => e.PRG_TY).HasMaxLength(4);

                entity.Property(e => e.SYS_NO)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.USE_TO).HasMaxLength(20);
            });

            modelBuilder.Entity<PAYYMCFG>(entity =>
            {
                entity.HasIndex(e => e.ROW_NO)
                    .HasName("PAYYMCFG_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ROW_NO)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.YYYYMM).HasMaxLength(6);
            });

            modelBuilder.Entity<PMSETRDL>(entity =>
            {
                entity.HasIndex(e => new { e.PMS_DT, e.CORP_NO, e.C_PRD, e.PMS_NO, e.EMP_NO })
                    .HasName("PMSETRDL_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.AMT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CORP_NO)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_PRD)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_SOURCE)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.EMP_NO)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PMS_DT).HasColumnType("datetime");

                entity.Property(e => e.PMS_NO)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PRC)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.QTY)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.REMK)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.cYYYYMM)
                    .HasColumnType("varchar(12)")
                    .HasComputedColumnSql("substring(CONVERT([varchar](100),[PMS_DT],(112)),(1),(6))")
                    .ValueGeneratedOnAddOrUpdate();
            });

            modelBuilder.Entity<PMSNAME>(entity =>
            {
                entity.HasIndex(e => e.NAME_NO)
                    .HasName("PMSNAME_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_ZERO).HasMaxLength(1);

                entity.Property(e => e.DISP_SR).HasMaxLength(10);

                entity.Property(e => e.IO).HasDefaultValueSql("1");

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.NAME_CLASS).HasMaxLength(10);

                entity.Property(e => e.NAME_NM).HasMaxLength(20);

                entity.Property(e => e.NAME_NO)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.REMK).HasMaxLength(255);
            });

            modelBuilder.Entity<PMSNO>(entity =>
            {
                entity.HasIndex(e => e.PMS_NO)
                    .HasName("PMSNO_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.ALT_SR).HasMaxLength(10);

                entity.Property(e => e.AMT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CAL_SR).HasMaxLength(10);

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CR_ACT_NO).HasMaxLength(20);

                entity.Property(e => e.C_ADD).HasMaxLength(1);

                entity.Property(e => e.C_CAL_TY).HasMaxLength(1);

                entity.Property(e => e.C_CST).HasMaxLength(1);

                entity.Property(e => e.C_DEPM_CR).HasMaxLength(1);

                entity.Property(e => e.C_DEPM_DR).HasMaxLength(1);

                entity.Property(e => e.C_EMP_CR).HasMaxLength(1);

                entity.Property(e => e.C_EMP_DR).HasMaxLength(1);

                entity.Property(e => e.C_FRL).HasMaxLength(1);

                entity.Property(e => e.C_IJT).HasMaxLength(1);

                entity.Property(e => e.C_SLY).HasMaxLength(1);

                entity.Property(e => e.C_TAX).HasMaxLength(1);

                entity.Property(e => e.C_WF).HasMaxLength(1);

                entity.Property(e => e.DISP_SR).HasMaxLength(10);

                entity.Property(e => e.DR_ACT_NO).HasMaxLength(20);

                entity.Property(e => e.IO).HasDefaultValueSql("1");

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.NAME_NO_1).HasMaxLength(10);

                entity.Property(e => e.NAME_NO_2).HasMaxLength(10);

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PMS_NM).HasMaxLength(20);

                entity.Property(e => e.PMS_NO)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.REMK).HasMaxLength(255);
            });

            modelBuilder.Entity<PNLCFG>(entity =>
            {
                entity.HasIndex(e => e.ROW_NO)
                    .HasName("PNLCFG_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.ADD_EXP_DDT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ADD_EXP_PMS_NO).HasMaxLength(10);

                entity.Property(e => e.ADD_EXP_RT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.DRAW_PMS_NO).HasMaxLength(10);

                entity.Property(e => e.EQUIP_PMS_NO).HasMaxLength(10);

                entity.Property(e => e.FRL_PMS_NO).HasMaxLength(10);

                entity.Property(e => e.HIS_ISU_NO).HasMaxLength(10);

                entity.Property(e => e.HIS_PMS_NO).HasMaxLength(10);

                entity.Property(e => e.HR_SLY_28)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HR_SLY_29)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HR_SLY_30)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HR_SLY_31)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HTH_AVG_PR)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HTH_MAX_PR).HasDefaultValueSql("0");

                entity.Property(e => e.IJT_FEE_PMS_NO).HasMaxLength(10);

                entity.Property(e => e.IJT_PMS_NO).HasMaxLength(10);

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.LIS_ISU_NO).HasMaxLength(10);

                entity.Property(e => e.LIS_PMS_NO).HasMaxLength(10);

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RET_PMS_NO).HasMaxLength(10);

                entity.Property(e => e.RET_YEE_RT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RET_YER_RT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ROW_NO)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.SPP_PMS_NO).HasMaxLength(10);

                entity.Property(e => e.TAX_PMS_NO).HasMaxLength(10);

                entity.Property(e => e.WF_PMS_NO).HasMaxLength(10);
            });

            modelBuilder.Entity<PRGNO>(entity =>
            {
                entity.HasIndex(e => e.PRG_NO)
                    .HasName("PRGNO_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_ADD).HasColumnType("char(1)");

                entity.Property(e => e.C_ATT).HasColumnType("char(1)");

                entity.Property(e => e.C_CFM).HasColumnType("char(1)");

                entity.Property(e => e.C_CPY).HasColumnType("char(1)");

                entity.Property(e => e.C_CST).HasColumnType("char(1)");

                entity.Property(e => e.C_DEL).HasColumnType("char(1)");

                entity.Property(e => e.C_EML).HasColumnType("char(1)");

                entity.Property(e => e.C_MDY).HasColumnType("char(1)");

                entity.Property(e => e.C_QRY).HasColumnType("char(1)");

                entity.Property(e => e.C_RUN).HasColumnType("char(1)");

                entity.Property(e => e.C_SIN).HasColumnType("char(1)");

                entity.Property(e => e.C_UCF).HasColumnType("char(1)");

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PRG_NM).HasMaxLength(30);

                entity.Property(e => e.PRG_NO)
                    .IsRequired()
                    .HasMaxLength(24);

                entity.Property(e => e.PRG_TY).HasMaxLength(4);

                entity.Property(e => e.PRG_URL1).HasMaxLength(80);

                entity.Property(e => e.PRG_URL2).HasMaxLength(80);

                entity.Property(e => e.SYS_NO).HasMaxLength(10);
            });

            modelBuilder.Entity<REWARD>(entity =>
            {
                entity.HasIndex(e => e.RWD_NO)
                    .HasName("REWARD_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PMS_NO).HasMaxLength(10);

                entity.Property(e => e.REMK).HasMaxLength(255);

                entity.Property(e => e.RWD_NO)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.RWN_NM).HasMaxLength(20);
            });

            modelBuilder.Entity<RWDPAY>(entity =>
            {
                entity.HasIndex(e => new { e.PAY_DT, e.RWD_NO, e.CORP_NO, e.C_PRD, e.EMP_NO })
                    .HasName("RWDPAY_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.ADD_EXP)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CORP_NO)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_PRD)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.C_SOURCE).HasMaxLength(1);

                entity.Property(e => e.EMP_NO)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PAY_AMT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PAY_DT).HasColumnType("datetime");

                entity.Property(e => e.REMK).HasMaxLength(255);

                entity.Property(e => e.RWD_NO)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.TAX)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TAX_RT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<SERJOB>(entity =>
            {
                entity.HasIndex(e => new { e.PID, e.ID })
                    .HasName("SERJOB_X9")
                    .IsUnique();

                entity.HasIndex(e => new { e.SER_NO, e.JOB_NO })
                    .HasName("SERJOB_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.BAS_HR_28).HasDefaultValueSql("0");

                entity.Property(e => e.BAS_HR_29).HasDefaultValueSql("0");

                entity.Property(e => e.BAS_HR_30).HasDefaultValueSql("0");

                entity.Property(e => e.BAS_HR_31).HasDefaultValueSql("0");

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.JOB_NO)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.NM_HR_SLY_28)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.NM_HR_SLY_29)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.NM_HR_SLY_30)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.NM_HR_SLY_31)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OVT_RT_28)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OVT_RT_29).HasColumnType("decimal");

                entity.Property(e => e.OVT_RT_30).HasColumnType("decimal");

                entity.Property(e => e.OVT_RT_31).HasColumnType("decimal");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PID).HasDefaultValueSql("newid()");

                entity.Property(e => e.REMK)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SER_NO)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SP_HR_SLY_28)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SP_HR_SLY_29)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SP_HR_SLY_30)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SP_HR_SLY_31)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.P)
                    .WithMany(p => p.SERJOB)
                    .HasForeignKey(d => d.PID)
                    .HasConstraintName("FK_SERJOB_SERVE");
            });

            modelBuilder.Entity<SERLEV>(entity =>
            {
                entity.HasIndex(e => new { e.SER_NO, e.D_SER_NO })
                    .HasName("SERLEV_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_SOURCE)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.D_SER_NO)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SER_NO)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<SERVE>(entity =>
            {
                entity.HasIndex(e => e.SER_NO)
                    .HasName("SERVE_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ACC_NM).HasMaxLength(80);

                entity.Property(e => e.ACC_NO).HasMaxLength(80);

                entity.Property(e => e.ADDR).HasMaxLength(80);

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.BANK_NO).HasMaxLength(10);

                entity.Property(e => e.BAS_HR_28).HasDefaultValueSql("0");

                entity.Property(e => e.BAS_HR_29).HasDefaultValueSql("0");

                entity.Property(e => e.BAS_HR_30).HasDefaultValueSql("0");

                entity.Property(e => e.BAS_HR_31).HasDefaultValueSql("0");

                entity.Property(e => e.CONTACTER).HasMaxLength(80);

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.DEPM_NO).HasMaxLength(10);

                entity.Property(e => e.EIP_SER_NO).HasMaxLength(10);

                entity.Property(e => e.FAX_NO).HasMaxLength(20);

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.NM_HR_SLY_28)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.NM_HR_SLY_29)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.NM_HR_SLY_30)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.NM_HR_SLY_31)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OVT_RT_28)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OVT_RT_29).HasColumnType("decimal");

                entity.Property(e => e.OVT_RT_30).HasColumnType("decimal");

                entity.Property(e => e.OVT_RT_31).HasColumnType("decimal");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PROPRIETOR).HasMaxLength(80);

                entity.Property(e => e.REMK).HasMaxLength(255);

                entity.Property(e => e.SER_NM).HasMaxLength(80);

                entity.Property(e => e.SER_NO)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.SHORT_NM).HasMaxLength(20);

                entity.Property(e => e.SP_HR_SLY_28)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SP_HR_SLY_29)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SP_HR_SLY_30)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SP_HR_SLY_31)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TAXRGT_NO).HasMaxLength(20);

                entity.Property(e => e.TEL_NO).HasMaxLength(20);

                entity.Property(e => e.TEL_NO2).HasMaxLength(20);

                entity.Property(e => e.TEL_NO3).HasMaxLength(20);

                entity.Property(e => e.UNIQUE_NO).HasMaxLength(20);

                entity.Property(e => e.U_SER_NO).HasMaxLength(10);

                entity.Property(e => e.ZNO_ADDR).HasMaxLength(10);
            });

            modelBuilder.Entity<SLVDL>(entity =>
            {
                entity.HasIndex(e => new { e.ID, e.PID })
                    .HasName("SLVDL_X9")
                    .IsUnique();

                entity.HasIndex(e => new { e.CORP_NO, e.SLV_NO, e.PMS_NO, e.C_PRD })
                    .HasName("SLVDL_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.AMT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CORP_NO)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_PRD)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PMS_NO)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.REMK).HasMaxLength(255);

                entity.Property(e => e.SLV_NO)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.HasOne(d => d.P)
                    .WithMany(p => p.SLVDL)
                    .HasForeignKey(d => d.PID)
                    .HasConstraintName("FK_SLVDL_SLVMT");
            });

            modelBuilder.Entity<SLVISU>(entity =>
            {
                entity.HasIndex(e => new { e.ID, e.PID })
                    .HasName("SLVISU_X9")
                    .IsUnique();

                entity.HasIndex(e => new { e.CORP_NO, e.SLV_NO, e.ISU_NO })
                    .HasName("SLVISU_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.AMT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CORP_NO)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ISU_NO)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.REMK).HasMaxLength(255);

                entity.Property(e => e.SLV_NO)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.HasOne(d => d.P)
                    .WithMany(p => p.SLVISU)
                    .HasForeignKey(d => d.PID)
                    .HasConstraintName("FK_SLVISU_SLVMT");
            });

            modelBuilder.Entity<SLVMT>(entity =>
            {
                entity.HasIndex(e => new { e.CORP_NO, e.SLV_NO })
                    .HasName("SLVMT_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.AMT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CORP_NO)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.REMK).HasMaxLength(255);

                entity.Property(e => e.SLV_NM).HasMaxLength(20);

                entity.Property(e => e.SLV_NO)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<SLYTRACT>(entity =>
            {
                entity.HasIndex(e => new { e.PID, e.ID })
                    .HasName("SLYTRACT_X9")
                    .IsUnique();

                entity.HasIndex(e => new { e.VCH_TY, e.VCH_NO, e.SR })
                    .HasName("SLYTRACT_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ACT_NO)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.AMT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BCH_NO)
                    .HasMaxLength(24)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CN_NO)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CS_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_DCR).HasDefaultValueSql("0");

                entity.Property(e => e.DEPM_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.EMP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PID).HasDefaultValueSql("newid()");

                entity.Property(e => e.REMK)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SER_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SR).HasDefaultValueSql("0");

                entity.Property(e => e.VCH_NO)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.VCH_TY)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasDefaultValueSql("''");

                entity.HasOne(d => d.P)
                    .WithMany(p => p.SLYTRACT)
                    .HasForeignKey(d => d.PID)
                    .HasConstraintName("FK_SLYTRACT_SLYTRMT");
            });

            modelBuilder.Entity<SLYTRDL>(entity =>
            {
                entity.HasIndex(e => new { e.PID, e.ID })
                    .HasName("SLYTRDL_X9")
                    .IsUnique();

                entity.HasIndex(e => new { e.VCH_TY, e.VCH_NO, e.EMP_NO })
                    .HasName("SLYTRDL_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ACC_ID_NO)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ACC_NM)
                    .HasMaxLength(80)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ACC_NO)
                    .HasMaxLength(80)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.AMT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BANK_ID)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.EMP_NO)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.NOT_NO)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PID).HasDefaultValueSql("newid()");

                entity.Property(e => e.REMK)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SER_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.VCH_NO)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.VCH_TY)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasDefaultValueSql("''");

                entity.HasOne(d => d.P)
                    .WithMany(p => p.SLYTRDL)
                    .HasForeignKey(d => d.PID)
                    .HasConstraintName("FK_SLYTRDL_SLYTRMT");
            });

            modelBuilder.Entity<SLYTRMT>(entity =>
            {
                entity.HasIndex(e => new { e.VCH_TY, e.VCH_NO })
                    .HasName("SLYTRMT_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ACT_NO)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.AVCH_NO)
                    .HasMaxLength(15)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.AVCH_TY)
                    .HasMaxLength(4)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.BANK_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CFM_DT).HasColumnType("datetime");

                entity.Property(e => e.CFM_USR_NO).HasMaxLength(10);

                entity.Property(e => e.CORP_NO)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_AJS)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_CFM)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_PAY_TY)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_PRD)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_SIGN)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.DEPM_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.DUE_DT).HasColumnType("datetime");

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.N_PRT).HasDefaultValueSql("0");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.REMK)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TR_DT).HasColumnType("datetime");

                entity.Property(e => e.VCH_DT).HasColumnType("datetime");

                entity.Property(e => e.VCH_NO)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.VCH_TY)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.YYYYMM)
                    .IsRequired()
                    .HasMaxLength(6)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<SYSCONFG>(entity =>
            {
                entity.HasIndex(e => e.ROW_NO)
                    .HasName("SYSCONFG_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ACT_CLS_DT).HasColumnType("datetime");

                entity.Property(e => e.ACT_CURR_YY).HasDefaultValueSql("0");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.AP_ACT_NO)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.AR_ACT_NO)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CLS_DT).HasColumnType("datetime");

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CURRENCY)
                    .HasMaxLength(4)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CURR_YM)
                    .HasMaxLength(6)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.DR_ACT_NO)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.DS_ACT_NO)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.EAR_DIFF_ACT_NO).HasMaxLength(20);

                entity.Property(e => e.IN_ACT_NO)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IVC_PAGE)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.NP_ACT_NO)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.NR_ACT_NO)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OT_ACT_NO)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PR_ACT_NO)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RAR_TY).HasColumnType("char(1)");

                entity.Property(e => e.ROW_NO)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.R_ACT_NO).HasMaxLength(20);

                entity.Property(e => e.R_BANK_NO).HasMaxLength(10);

                entity.Property(e => e.R_BCH_NO).HasMaxLength(24);

                entity.Property(e => e.SLY_CASH_ACT_NO).HasMaxLength(20);

                entity.Property(e => e.SLY_NP_ACT_NO).HasMaxLength(20);

                entity.Property(e => e.TAX_RT)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TAX_TY)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<SYSNO>(entity =>
            {
                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SYS_NM).HasMaxLength(20);

                entity.Property(e => e.SYS_NO).HasMaxLength(10);
            });

            modelBuilder.Entity<TITLE>(entity =>
            {
                entity.HasIndex(e => e.TITLE_NO)
                    .HasName("TITLE_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.REMK)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TITLE_NM)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TITLE_NO)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<USRARDEPM>(entity =>
            {
                entity.HasIndex(e => new { e.PID, e.ID })
                    .HasName("USRARDEPM_X9")
                    .IsUnique();

                entity.HasIndex(e => new { e.USR_NO, e.GRP_SR })
                    .HasName("USRARDEPM_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.DEPM_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.GRP_SR).HasDefaultValueSql("0");

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PID).HasDefaultValueSql("newid()");

                entity.Property(e => e.USR_NO)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.HasOne(d => d.P)
                    .WithMany(p => p.USRARDEPM)
                    .HasForeignKey(d => d.PID)
                    .HasConstraintName("FK_USRARDEPM_USRNO");
            });

            modelBuilder.Entity<USRGRP>(entity =>
            {
                entity.HasIndex(e => new { e.ID, e.PID })
                    .HasName("USRGRP_X9")
                    .IsUnique();

                entity.HasIndex(e => new { e.USR_NO, e.GRP_SR })
                    .HasName("USRGRP_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.GRP_NO).HasMaxLength(10);

                entity.Property(e => e.GRP_SR).HasDefaultValueSql("0");

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.USR_NO)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.HasOne(d => d.P)
                    .WithMany(p => p.USRGRP)
                    .HasForeignKey(d => d.PID)
                    .HasConstraintName("FK_USRGRP_USRNO");
            });

            modelBuilder.Entity<USRIVCDEPM>(entity =>
            {
                entity.HasIndex(e => new { e.PID, e.ID })
                    .HasName("USRIVCDEPM_X9")
                    .IsUnique();

                entity.HasIndex(e => new { e.USR_NO, e.GRP_SR })
                    .HasName("USRIVCDEPM_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.DEPM_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.GRP_SR).HasDefaultValueSql("0");

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PID).HasDefaultValueSql("newid()");

                entity.Property(e => e.USR_NO)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.HasOne(d => d.P)
                    .WithMany(p => p.USRIVCDEPM)
                    .HasForeignKey(d => d.PID)
                    .HasConstraintName("FK_USRIVCDEPM_USRNO");
            });

            modelBuilder.Entity<USRNO>(entity =>
            {
                entity.HasIndex(e => e.USR_NO)
                    .HasName("USRNO_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.CORP_NO).HasMaxLength(10);

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_SUPER).HasMaxLength(1);

                entity.Property(e => e.EFF_DT).HasColumnType("datetime");

                entity.Property(e => e.EXP_DT).HasColumnType("datetime");

                entity.Property(e => e.GRP_NO).HasMaxLength(10);

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PW_DT).HasColumnType("datetime");

                entity.Property(e => e.SLY_DEPM_NO).HasMaxLength(10);

                entity.Property(e => e.USR_NM).HasMaxLength(20);

                entity.Property(e => e.USR_NO)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.USR_PW).HasMaxLength(50);

                entity.Property(e => e.VLD_DAY).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<USRPMS>(entity =>
            {
                entity.HasIndex(e => new { e.ID, e.PID })
                    .HasName("USRPMS_X9")
                    .IsUnique();

                entity.HasIndex(e => new { e.USR_NO, e.PRG_NO })
                    .HasName("USRPMS_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_ADD).HasColumnType("char(1)");

                entity.Property(e => e.C_ATT).HasColumnType("char(1)");

                entity.Property(e => e.C_CFM).HasColumnType("char(1)");

                entity.Property(e => e.C_CPY).HasColumnType("char(1)");

                entity.Property(e => e.C_CST).HasColumnType("char(1)");

                entity.Property(e => e.C_DEL).HasColumnType("char(1)");

                entity.Property(e => e.C_EML).HasColumnType("char(1)");

                entity.Property(e => e.C_MDY).HasColumnType("char(1)");

                entity.Property(e => e.C_QRY).HasColumnType("char(1)");

                entity.Property(e => e.C_RUN).HasColumnType("char(1)");

                entity.Property(e => e.C_SIN).HasColumnType("char(1)");

                entity.Property(e => e.C_UCF).HasColumnType("char(1)");

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PRG_NO)
                    .IsRequired()
                    .HasColumnType("char(24)");

                entity.Property(e => e.USR_NO)
                    .IsRequired()
                    .HasColumnType("char(10)");

                entity.HasOne(d => d.P)
                    .WithMany(p => p.USRPMS)
                    .HasForeignKey(d => d.PID)
                    .HasConstraintName("FK_USRPMS_USRNO");
            });

            modelBuilder.Entity<USRRARDEPM>(entity =>
            {
                entity.HasIndex(e => new { e.PID, e.ID })
                    .HasName("USRRARDEPM_X9")
                    .IsUnique();

                entity.HasIndex(e => new { e.USR_NO, e.GRP_SR })
                    .HasName("USRRARDEPM_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.DEPM_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.GRP_SR).HasDefaultValueSql("0");

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PID).HasDefaultValueSql("newid()");

                entity.Property(e => e.USR_NO)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.HasOne(d => d.P)
                    .WithMany(p => p.USRRARDEPM)
                    .HasForeignKey(d => d.PID)
                    .HasConstraintName("FK_USRRARDEPM_USRNO");
            });

            modelBuilder.Entity<VCHCFMLG>(entity =>
            {
                entity.HasIndex(e => new { e.VCH_TY, e.VCH_NO, e.CFM_DT })
                    .HasName("VCHCFMLGX1");

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.CFM_DT).HasColumnType("datetime");

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_CFM)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.VCH_NO)
                    .HasMaxLength(15)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.VCH_TY)
                    .HasMaxLength(4)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<VCHCONFG>(entity =>
            {
                entity.HasIndex(e => e.VCH_TY)
                    .HasName("VCHCONFG_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.ATTR)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CLS_DT).HasColumnType("datetime");

                entity.Property(e => e.CODE_LEN).HasDefaultValueSql("0");

                entity.Property(e => e.CODE_TY)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CR_ACT_NO)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_SIGN)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_USR)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.DR_ACT_NO)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.EXCH_TY)
                    .HasMaxLength(4)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IO).HasDefaultValueSql("1");

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PRG_NO)
                    .HasMaxLength(24)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.REMK)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.VCH_NM)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.VCH_TY)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<VCHUSR>(entity =>
            {
                entity.HasIndex(e => new { e.PID, e.ID })
                    .HasName("VCHUSR_X9")
                    .IsUnique();

                entity.HasIndex(e => new { e.VCH_TY, e.USR_NO })
                    .HasName("VCHUSR_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_ADD)
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_ATT)
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_CFM)
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_CPY)
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_CST)
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_DEL)
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_EML)
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_MDY)
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_QRY)
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_RUN)
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_SIN)
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.C_UCF)
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PID).HasDefaultValueSql("newid()");

                entity.Property(e => e.USR_NO)
                    .IsRequired()
                    .HasColumnType("char(10)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.VCH_TY)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasDefaultValueSql("''");

                entity.HasOne(d => d.P)
                    .WithMany(p => p.VCHUSR)
                    .HasForeignKey(d => d.PID)
                    .HasConstraintName("FK_VCHUSR_VCHCONFG");
            });

            modelBuilder.Entity<VENDOR>(entity =>
            {
                entity.HasIndex(e => e.VD_NO)
                    .HasName("VENDOR_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ACC_NM).HasMaxLength(80);

                entity.Property(e => e.ACC_NO).HasMaxLength(80);

                entity.Property(e => e.ACC_TY).HasMaxLength(10);

                entity.Property(e => e.ADDR_OFC).HasMaxLength(80);

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.AP_ACT_NO).HasMaxLength(20);

                entity.Property(e => e.AP_BCH_NO).HasMaxLength(24);

                entity.Property(e => e.BANK_ID).HasMaxLength(10);

                entity.Property(e => e.BANK_NO).HasMaxLength(10);

                entity.Property(e => e.CONTACTER)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CONTACTER2)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CONTACTER3)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.EAP_ACT_NO).HasMaxLength(20);

                entity.Property(e => e.EAP_BCH_NO).HasMaxLength(24);

                entity.Property(e => e.E_MAIL).HasMaxLength(80);

                entity.Property(e => e.FAX_NO)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.FULL_NM).HasMaxLength(80);

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IVC_PAGE).HasMaxLength(1);

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.NP_ACT_NO).HasMaxLength(20);

                entity.Property(e => e.NP_BCH_NO).HasMaxLength(24);

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PAY_TY).HasMaxLength(10);

                entity.Property(e => e.PP_ACT_NO).HasMaxLength(20);

                entity.Property(e => e.PP_BCH_NO).HasMaxLength(24);

                entity.Property(e => e.PROPRIETOR).HasMaxLength(30);

                entity.Property(e => e.REMK).HasMaxLength(255);

                entity.Property(e => e.SHORT_NM).HasMaxLength(10);

                entity.Property(e => e.TAX_RT).HasColumnType("decimal");

                entity.Property(e => e.TAX_TY).HasMaxLength(1);

                entity.Property(e => e.TEL_NO)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TEL_NO2)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TEL_NO3)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.UNIQUE_NO).HasMaxLength(20);

                entity.Property(e => e.VD_NO)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.WWW).HasMaxLength(80);

                entity.Property(e => e.ZNO_OFC).HasMaxLength(10);
            });

            modelBuilder.Entity<VITEM>(entity =>
            {
                entity.HasIndex(e => e.VITEM_NO)
                    .HasName("VITEM_X1")
                    .IsUnique();

                entity.Property(e => e.ID).HasDefaultValueSql("newid()");

                entity.Property(e => e.ADD_DT).HasColumnType("datetime");

                entity.Property(e => e.CP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IP_NM)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MDY_DT).HasColumnType("datetime");

                entity.Property(e => e.MDY_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_GRP_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OWNER_USR_NO)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.UNIT).HasMaxLength(4);

                entity.Property(e => e.VITEM_NM)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.VITEM_NO)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.VITEM_TY)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''");
            });
        }
    }
}