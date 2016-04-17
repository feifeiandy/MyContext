using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using MyContext.Models.Mapping;

namespace MyContext.Models
{
    public partial class aisino_mesContext : DbContext
    {
        static aisino_mesContext()
        {
            Database.SetInitializer<aisino_mesContext>(null);
        }

        public aisino_mesContext()
            : base("Name=aisino_mesContext")
        {
        }

        public DbSet<AssayDetail> AssayDetails { get; set; }
        public DbSet<AssayMaster> AssayMasters { get; set; }
        public DbSet<AssayMasterResult> AssayMasterResults { get; set; }
        public DbSet<AssayResult> AssayResults { get; set; }
        public DbSet<BomDetail> BomDetails { get; set; }
        public DbSet<BomDetailSection> BomDetailSections { get; set; }
        public DbSet<BomMaster> BomMasters { get; set; }
        public DbSet<BomSubsidiary> BomSubsidiaries { get; set; }
        public DbSet<BorGroupMaster> BorGroupMasters { get; set; }
        public DbSet<BorLine> BorLines { get; set; }
        public DbSet<BorLineSection> BorLineSections { get; set; }
        public DbSet<BorSection> BorSections { get; set; }
        public DbSet<BorSectionEquipment> BorSectionEquipments { get; set; }
        public DbSet<BorType> BorTypes { get; set; }
        public DbSet<BusinessCustomer> BusinessCustomers { get; set; }
        public DbSet<CusAndCardInfor> CusAndCardInfors { get; set; }
        public DbSet<CustomerRechargeInfor> CustomerRechargeInfors { get; set; }
        public DbSet<CustomerRechargeRecord> CustomerRechargeRecords { get; set; }
        public DbSet<CustomerTransactionInfor> CustomerTransactionInfors { get; set; }
        public DbSet<DCSExchange> DCSExchanges { get; set; }
        public DbSet<DCSManu> DCSManus { get; set; }
        public DbSet<DCSPurchase> DCSPurchases { get; set; }
        public DbSet<DCSSale> DCSSales { get; set; }
        public DbSet<DeductIndex> DeductIndexes { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<EquipmentMaintReason> EquipmentMaintReasons { get; set; }
        public DbSet<EquipmentMaintReasonType> EquipmentMaintReasonTypes { get; set; }
        public DbSet<EquipmentType> EquipmentTypes { get; set; }
        public DbSet<GrainCharacter> GrainCharacters { get; set; }
        public DbSet<InvmasDeductIndex> InvmasDeductIndexes { get; set; }
        public DbSet<InvmasQualityIndex> InvmasQualityIndexes { get; set; }
        public DbSet<LipaDensityInfo> LipaDensityInfoes { get; set; }
        public DbSet<ManuPlanTask> ManuPlanTasks { get; set; }
        public DbSet<ManuPlanTaskBatch> ManuPlanTaskBatches { get; set; }
        public DbSet<ManuPlanTaskBatchInWarehouse> ManuPlanTaskBatchInWarehouses { get; set; }
        public DbSet<ManuPlanTaskBatchOutWarehouse> ManuPlanTaskBatchOutWarehouses { get; set; }
        public DbSet<ManuPlanTaskBatchTransDetail> ManuPlanTaskBatchTransDetails { get; set; }
        public DbSet<ManuPlanTaskBom> ManuPlanTaskBoms { get; set; }
        public DbSet<PlanTaskType> PlanTaskTypes { get; set; }
        public DbSet<PlanTaskTypeInOutDetail> PlanTaskTypeInOutDetails { get; set; }
        public DbSet<QualityBaseCode> QualityBaseCodes { get; set; }
        public DbSet<QualityBaseConfig> QualityBaseConfigs { get; set; }
        public DbSet<QualityGrade> QualityGrades { get; set; }
        public DbSet<QualityGradeIndex> QualityGradeIndexes { get; set; }
        public DbSet<QualityIndex> QualityIndexes { get; set; }
        public DbSet<QualityStandard> QualityStandards { get; set; }
        public DbSet<RFIDTag> RFIDTags { get; set; }
        public DbSet<SampleDetail> SampleDetails { get; set; }
        public DbSet<SampleMaster> SampleMasters { get; set; }
        public DbSet<SampleType> SampleTypes { get; set; }
        public DbSet<SysBillNo> SysBillNoes { get; set; }
        public DbSet<SysCode> SysCodes { get; set; }
        public DbSet<SysCompanyInfo> SysCompanyInfoes { get; set; }
        public DbSet<SysDepartment> SysDepartments { get; set; }
        public DbSet<SysFunction> SysFunctions { get; set; }
        public DbSet<SysHardwareConfig> SysHardwareConfigs { get; set; }
        public DbSet<SysLogInfo> SysLogInfoes { get; set; }
        public DbSet<SysMenu> SysMenus { get; set; }
        public DbSet<SysModule> SysModules { get; set; }
        public DbSet<SysRight> SysRights { get; set; }
        public DbSet<SysRole> SysRoles { get; set; }
        public DbSet<SysRoleUser> SysRoleUsers { get; set; }
        public DbSet<SysSubSystem> SysSubSystems { get; set; }
        public DbSet<SysUser> SysUsers { get; set; }
        public DbSet<SysUserFavorite> SysUserFavorites { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<WarehouseAllocation> WarehouseAllocations { get; set; }
        public DbSet<WarehouseAmount> WarehouseAmounts { get; set; }
        public DbSet<WarehouseAmountTransDetail> WarehouseAmountTransDetails { get; set; }
        public DbSet<WarehouseBaseConfig> WarehouseBaseConfigs { get; set; }
        public DbSet<WarehouseBatchDetail> WarehouseBatchDetails { get; set; }
        public DbSet<WarehouseBatchMaster> WarehouseBatchMasters { get; set; }
        public DbSet<WarehouseCarryOverByDay> WarehouseCarryOverByDays { get; set; }
        public DbSet<WarehouseCarryOverByMonth> WarehouseCarryOverByMonths { get; set; }
        public DbSet<WarehouseDefaultOilMachine> WarehouseDefaultOilMachines { get; set; }
        public DbSet<WarehouseDetail> WarehouseDetails { get; set; }
        public DbSet<WarehouseInvcl> WarehouseInvcls { get; set; }
        public DbSet<WarehouseInvma> WarehouseInvmas { get; set; }
        public DbSet<WarehouseInvmasCharacter> WarehouseInvmasCharacters { get; set; }
        public DbSet<WarehouseInvmasDetail> WarehouseInvmasDetails { get; set; }
        public DbSet<WarehouseLocation> WarehouseLocations { get; set; }
        public DbSet<WarehouseTransactionDetail> WarehouseTransactionDetails { get; set; }
        public DbSet<WarehouseTransactionMaster> WarehouseTransactionMasters { get; set; }
        public DbSet<WarehouseTransactionOperatorLog> WarehouseTransactionOperatorLogs { get; set; }
        public DbSet<WarehousetransInfor> WarehousetransInfors { get; set; }
        public DbSet<WarehouseType> WarehouseTypes { get; set; }
        public DbSet<WarehouseUnit> WarehouseUnits { get; set; }
        public DbSet<WarehouseUnitConversion> WarehouseUnitConversions { get; set; }
        public DbSet<WarehouseUnitType> WarehouseUnitTypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AssayDetailMap());
            modelBuilder.Configurations.Add(new AssayMasterMap());
            modelBuilder.Configurations.Add(new AssayMasterResultMap());
            modelBuilder.Configurations.Add(new AssayResultMap());
            modelBuilder.Configurations.Add(new BomDetailMap());
            modelBuilder.Configurations.Add(new BomDetailSectionMap());
            modelBuilder.Configurations.Add(new BomMasterMap());
            modelBuilder.Configurations.Add(new BomSubsidiaryMap());
            modelBuilder.Configurations.Add(new BorGroupMasterMap());
            modelBuilder.Configurations.Add(new BorLineMap());
            modelBuilder.Configurations.Add(new BorLineSectionMap());
            modelBuilder.Configurations.Add(new BorSectionMap());
            modelBuilder.Configurations.Add(new BorSectionEquipmentMap());
            modelBuilder.Configurations.Add(new BorTypeMap());
            modelBuilder.Configurations.Add(new BusinessCustomerMap());
            modelBuilder.Configurations.Add(new CusAndCardInforMap());
            modelBuilder.Configurations.Add(new CustomerRechargeInforMap());
            modelBuilder.Configurations.Add(new CustomerRechargeRecordMap());
            modelBuilder.Configurations.Add(new CustomerTransactionInforMap());
            modelBuilder.Configurations.Add(new DCSExchangeMap());
            modelBuilder.Configurations.Add(new DCSManuMap());
            modelBuilder.Configurations.Add(new DCSPurchaseMap());
            modelBuilder.Configurations.Add(new DCSSaleMap());
            modelBuilder.Configurations.Add(new DeductIndexMap());
            modelBuilder.Configurations.Add(new DistrictMap());
            modelBuilder.Configurations.Add(new EquipmentMap());
            modelBuilder.Configurations.Add(new EquipmentMaintReasonMap());
            modelBuilder.Configurations.Add(new EquipmentMaintReasonTypeMap());
            modelBuilder.Configurations.Add(new EquipmentTypeMap());
            modelBuilder.Configurations.Add(new GrainCharacterMap());
            modelBuilder.Configurations.Add(new InvmasDeductIndexMap());
            modelBuilder.Configurations.Add(new InvmasQualityIndexMap());
            modelBuilder.Configurations.Add(new LipaDensityInfoMap());
            modelBuilder.Configurations.Add(new ManuPlanTaskMap());
            modelBuilder.Configurations.Add(new ManuPlanTaskBatchMap());
            modelBuilder.Configurations.Add(new ManuPlanTaskBatchInWarehouseMap());
            modelBuilder.Configurations.Add(new ManuPlanTaskBatchOutWarehouseMap());
            modelBuilder.Configurations.Add(new ManuPlanTaskBatchTransDetailMap());
            modelBuilder.Configurations.Add(new ManuPlanTaskBomMap());
            modelBuilder.Configurations.Add(new PlanTaskTypeMap());
            modelBuilder.Configurations.Add(new PlanTaskTypeInOutDetailMap());
            modelBuilder.Configurations.Add(new QualityBaseCodeMap());
            modelBuilder.Configurations.Add(new QualityBaseConfigMap());
            modelBuilder.Configurations.Add(new QualityGradeMap());
            modelBuilder.Configurations.Add(new QualityGradeIndexMap());
            modelBuilder.Configurations.Add(new QualityIndexMap());
            modelBuilder.Configurations.Add(new QualityStandardMap());
            modelBuilder.Configurations.Add(new RFIDTagMap());
            modelBuilder.Configurations.Add(new SampleDetailMap());
            modelBuilder.Configurations.Add(new SampleMasterMap());
            modelBuilder.Configurations.Add(new SampleTypeMap());
            modelBuilder.Configurations.Add(new SysBillNoMap());
            modelBuilder.Configurations.Add(new SysCodeMap());
            modelBuilder.Configurations.Add(new SysCompanyInfoMap());
            modelBuilder.Configurations.Add(new SysDepartmentMap());
            modelBuilder.Configurations.Add(new SysFunctionMap());
            modelBuilder.Configurations.Add(new SysHardwareConfigMap());
            modelBuilder.Configurations.Add(new SysLogInfoMap());
            modelBuilder.Configurations.Add(new SysMenuMap());
            modelBuilder.Configurations.Add(new SysModuleMap());
            modelBuilder.Configurations.Add(new SysRightMap());
            modelBuilder.Configurations.Add(new SysRoleMap());
            modelBuilder.Configurations.Add(new SysRoleUserMap());
            modelBuilder.Configurations.Add(new SysSubSystemMap());
            modelBuilder.Configurations.Add(new SysUserMap());
            modelBuilder.Configurations.Add(new SysUserFavoriteMap());
            modelBuilder.Configurations.Add(new WarehouseMap());
            modelBuilder.Configurations.Add(new WarehouseAllocationMap());
            modelBuilder.Configurations.Add(new WarehouseAmountMap());
            modelBuilder.Configurations.Add(new WarehouseAmountTransDetailMap());
            modelBuilder.Configurations.Add(new WarehouseBaseConfigMap());
            modelBuilder.Configurations.Add(new WarehouseBatchDetailMap());
            modelBuilder.Configurations.Add(new WarehouseBatchMasterMap());
            modelBuilder.Configurations.Add(new WarehouseCarryOverByDayMap());
            modelBuilder.Configurations.Add(new WarehouseCarryOverByMonthMap());
            modelBuilder.Configurations.Add(new WarehouseDefaultOilMachineMap());
            modelBuilder.Configurations.Add(new WarehouseDetailMap());
            modelBuilder.Configurations.Add(new WarehouseInvclMap());
            modelBuilder.Configurations.Add(new WarehouseInvmaMap());
            modelBuilder.Configurations.Add(new WarehouseInvmasCharacterMap());
            modelBuilder.Configurations.Add(new WarehouseInvmasDetailMap());
            modelBuilder.Configurations.Add(new WarehouseLocationMap());
            modelBuilder.Configurations.Add(new WarehouseTransactionDetailMap());
            modelBuilder.Configurations.Add(new WarehouseTransactionMasterMap());
            modelBuilder.Configurations.Add(new WarehouseTransactionOperatorLogMap());
            modelBuilder.Configurations.Add(new WarehousetransInforMap());
            modelBuilder.Configurations.Add(new WarehouseTypeMap());
            modelBuilder.Configurations.Add(new WarehouseUnitMap());
            modelBuilder.Configurations.Add(new WarehouseUnitConversionMap());
            modelBuilder.Configurations.Add(new WarehouseUnitTypeMap());
        }
    }
}
