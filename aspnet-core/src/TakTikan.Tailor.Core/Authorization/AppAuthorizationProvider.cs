﻿using Abp.Authorization;
using Abp.Configuration.Startup;
using Abp.Localization;
using Abp.MultiTenancy;

namespace TakTikan.Tailor.Authorization
{
    /// <summary>
    /// Application's authorization provider.
    /// Defines permissions for the application.
    /// See <see cref="AppPermissions"/> for all permission names.
    /// </summary>
    public class AppAuthorizationProvider : AuthorizationProvider
    {
        private readonly bool _isMultiTenancyEnabled;

        public AppAuthorizationProvider(bool isMultiTenancyEnabled)
        {
            _isMultiTenancyEnabled = isMultiTenancyEnabled;
        }

        public AppAuthorizationProvider(IMultiTenancyConfig multiTenancyConfig)
        {
            _isMultiTenancyEnabled = multiTenancyConfig.IsEnabled;
        }

        public override void SetPermissions(IPermissionDefinitionContext context)
        {
            //COMMON PERMISSIONS (FOR BOTH OF TENANTS AND HOST)

            var pages = context.GetPermissionOrNull(AppPermissions.Pages) ?? context.CreatePermission(AppPermissions.Pages, L("Pages"));
            pages.CreateChildPermission(AppPermissions.Pages_DemoUiComponents, L("DemoUiComponents"));

            var administration = pages.CreateChildPermission(AppPermissions.Pages_Administration, L("Administration"));

            var roles = administration.CreateChildPermission(AppPermissions.Pages_Administration_Roles, L("Roles"));
            roles.CreateChildPermission(AppPermissions.Pages_Administration_Roles_Create, L("CreatingNewRole"));
            roles.CreateChildPermission(AppPermissions.Pages_Administration_Roles_Edit, L("EditingRole"));
            roles.CreateChildPermission(AppPermissions.Pages_Administration_Roles_Delete, L("DeletingRole"));

            var users = administration.CreateChildPermission(AppPermissions.Pages_Administration_Users, L("Users"));
            users.CreateChildPermission(AppPermissions.Pages_Administration_Users_Create, L("CreatingNewUser"));
            users.CreateChildPermission(AppPermissions.Pages_Administration_Users_Edit, L("EditingUser"));
            users.CreateChildPermission(AppPermissions.Pages_Administration_Users_Delete, L("DeletingUser"));
            users.CreateChildPermission(AppPermissions.Pages_Administration_Users_ChangePermissions, L("ChangingPermissions"));
            users.CreateChildPermission(AppPermissions.Pages_Administration_Users_Impersonation, L("LoginForUsers"));
            users.CreateChildPermission(AppPermissions.Pages_Administration_Users_Unlock, L("Unlock"));

            var languages = administration.CreateChildPermission(AppPermissions.Pages_Administration_Languages, L("Languages"));
            languages.CreateChildPermission(AppPermissions.Pages_Administration_Languages_Create, L("CreatingNewLanguage"), multiTenancySides: _isMultiTenancyEnabled ? MultiTenancySides.Host : MultiTenancySides.Tenant);
            languages.CreateChildPermission(AppPermissions.Pages_Administration_Languages_Edit, L("EditingLanguage"), multiTenancySides: _isMultiTenancyEnabled ? MultiTenancySides.Host : MultiTenancySides.Tenant);
            languages.CreateChildPermission(AppPermissions.Pages_Administration_Languages_Delete, L("DeletingLanguages"), multiTenancySides: _isMultiTenancyEnabled ? MultiTenancySides.Host : MultiTenancySides.Tenant);
            languages.CreateChildPermission(AppPermissions.Pages_Administration_Languages_ChangeTexts, L("ChangingTexts"));

            administration.CreateChildPermission(AppPermissions.Pages_Administration_AuditLogs, L("AuditLogs"));

            var organizationUnits = administration.CreateChildPermission(AppPermissions.Pages_Administration_OrganizationUnits, L("OrganizationUnits"));
            organizationUnits.CreateChildPermission(AppPermissions.Pages_Administration_OrganizationUnits_ManageOrganizationTree, L("ManagingOrganizationTree"));
            organizationUnits.CreateChildPermission(AppPermissions.Pages_Administration_OrganizationUnits_ManageMembers, L("ManagingMembers"));
            organizationUnits.CreateChildPermission(AppPermissions.Pages_Administration_OrganizationUnits_ManageRoles, L("ManagingRoles"));

            administration.CreateChildPermission(AppPermissions.Pages_Administration_UiCustomization, L("VisualSettings"));

            var webhooks = administration.CreateChildPermission(AppPermissions.Pages_Administration_WebhookSubscription, L("Webhooks"));
            webhooks.CreateChildPermission(AppPermissions.Pages_Administration_WebhookSubscription_Create, L("CreatingWebhooks"));
            webhooks.CreateChildPermission(AppPermissions.Pages_Administration_WebhookSubscription_Edit, L("EditingWebhooks"));
            webhooks.CreateChildPermission(AppPermissions.Pages_Administration_WebhookSubscription_ChangeActivity, L("ChangingWebhookActivity"));
            webhooks.CreateChildPermission(AppPermissions.Pages_Administration_WebhookSubscription_Detail, L("DetailingSubscription"));
            webhooks.CreateChildPermission(AppPermissions.Pages_Administration_Webhook_ListSendAttempts, L("ListingSendAttempts"));
            webhooks.CreateChildPermission(AppPermissions.Pages_Administration_Webhook_ResendWebhook, L("ResendingWebhook"));

            var dynamicProperties = administration.CreateChildPermission(AppPermissions.Pages_Administration_DynamicProperties, L("DynamicProperties"));
            dynamicProperties.CreateChildPermission(AppPermissions.Pages_Administration_DynamicProperties_Create, L("CreatingDynamicProperties"));
            dynamicProperties.CreateChildPermission(AppPermissions.Pages_Administration_DynamicProperties_Edit, L("EditingDynamicProperties"));
            dynamicProperties.CreateChildPermission(AppPermissions.Pages_Administration_DynamicProperties_Delete, L("DeletingDynamicProperties"));

            var dynamicPropertyValues = dynamicProperties.CreateChildPermission(AppPermissions.Pages_Administration_DynamicPropertyValue, L("DynamicPropertyValue"));
            dynamicPropertyValues.CreateChildPermission(AppPermissions.Pages_Administration_DynamicPropertyValue_Create, L("CreatingDynamicPropertyValue"));
            dynamicPropertyValues.CreateChildPermission(AppPermissions.Pages_Administration_DynamicPropertyValue_Edit, L("EditingDynamicPropertyValue"));
            dynamicPropertyValues.CreateChildPermission(AppPermissions.Pages_Administration_DynamicPropertyValue_Delete, L("DeletingDynamicPropertyValue"));

            var dynamicEntityProperties = dynamicProperties.CreateChildPermission(AppPermissions.Pages_Administration_DynamicEntityProperties, L("DynamicEntityProperties"));
            dynamicEntityProperties.CreateChildPermission(AppPermissions.Pages_Administration_DynamicEntityProperties_Create, L("CreatingDynamicEntityProperties"));
            dynamicEntityProperties.CreateChildPermission(AppPermissions.Pages_Administration_DynamicEntityProperties_Edit, L("EditingDynamicEntityProperties"));
            dynamicEntityProperties.CreateChildPermission(AppPermissions.Pages_Administration_DynamicEntityProperties_Delete, L("DeletingDynamicEntityProperties"));

            var dynamicEntityPropertyValues = dynamicProperties.CreateChildPermission(AppPermissions.Pages_Administration_DynamicEntityPropertyValue, L("EntityDynamicPropertyValue"));
            dynamicEntityPropertyValues.CreateChildPermission(AppPermissions.Pages_Administration_DynamicEntityPropertyValue_Create, L("CreatingDynamicEntityPropertyValue"));
            dynamicEntityPropertyValues.CreateChildPermission(AppPermissions.Pages_Administration_DynamicEntityPropertyValue_Edit, L("EditingDynamicEntityPropertyValue"));
            dynamicEntityPropertyValues.CreateChildPermission(AppPermissions.Pages_Administration_DynamicEntityPropertyValue_Delete, L("DeletingDynamicEntityPropertyValue"));

            //TENANT-SPECIFIC PERMISSIONS

            pages.CreateChildPermission(AppPermissions.Pages_Tenant_Dashboard, L("Dashboard"), multiTenancySides: MultiTenancySides.Tenant);

            administration.CreateChildPermission(AppPermissions.Pages_Administration_Tenant_Settings, L("Settings"), multiTenancySides: MultiTenancySides.Tenant);
            administration.CreateChildPermission(AppPermissions.Pages_Administration_Tenant_SubscriptionManagement, L("Subscription"), multiTenancySides: MultiTenancySides.Tenant);

            //HOST-SPECIFIC PERMISSIONS

            var editions = pages.CreateChildPermission(AppPermissions.Pages_Editions, L("Editions"), multiTenancySides: MultiTenancySides.Host);
            editions.CreateChildPermission(AppPermissions.Pages_Editions_Create, L("CreatingNewEdition"), multiTenancySides: MultiTenancySides.Host);
            editions.CreateChildPermission(AppPermissions.Pages_Editions_Edit, L("EditingEdition"), multiTenancySides: MultiTenancySides.Host);
            editions.CreateChildPermission(AppPermissions.Pages_Editions_Delete, L("DeletingEdition"), multiTenancySides: MultiTenancySides.Host);
            editions.CreateChildPermission(AppPermissions.Pages_Editions_MoveTenantsToAnotherEdition, L("MoveTenantsToAnotherEdition"), multiTenancySides: MultiTenancySides.Host);

            var tenants = pages.CreateChildPermission(AppPermissions.Pages_Tenants, L("Tenants"), multiTenancySides: MultiTenancySides.Host);
            tenants.CreateChildPermission(AppPermissions.Pages_Tenants_Create, L("CreatingNewTenant"), multiTenancySides: MultiTenancySides.Host);
            tenants.CreateChildPermission(AppPermissions.Pages_Tenants_Edit, L("EditingTenant"), multiTenancySides: MultiTenancySides.Host);
            tenants.CreateChildPermission(AppPermissions.Pages_Tenants_ChangeFeatures, L("ChangingFeatures"), multiTenancySides: MultiTenancySides.Host);
            tenants.CreateChildPermission(AppPermissions.Pages_Tenants_Delete, L("DeletingTenant"), multiTenancySides: MultiTenancySides.Host);
            tenants.CreateChildPermission(AppPermissions.Pages_Tenants_Impersonation, L("LoginForTenants"), multiTenancySides: MultiTenancySides.Host);

            administration.CreateChildPermission(AppPermissions.Pages_Administration_Host_Settings, L("Settings"), multiTenancySides: MultiTenancySides.Host);
            administration.CreateChildPermission(AppPermissions.Pages_Administration_Host_Maintenance, L("Maintenance"), multiTenancySides: _isMultiTenancyEnabled ? MultiTenancySides.Host : MultiTenancySides.Tenant);
            administration.CreateChildPermission(AppPermissions.Pages_Administration_HangfireDashboard, L("HangfireDashboard"), multiTenancySides: _isMultiTenancyEnabled ? MultiTenancySides.Host : MultiTenancySides.Tenant);
            administration.CreateChildPermission(AppPermissions.Pages_Administration_Host_Dashboard, L("Dashboard"), multiTenancySides: MultiTenancySides.Host);

            var taktikan = pages.CreateChildPermission(AppPermissions.Pages_TakTikan, L("TakTikan"));

            var FabricCut = taktikan.CreateChildPermission(AppPermissions.Pages_TakTikan_FabricCut, L("FabricCut"));
            FabricCut.CreateChildPermission(AppPermissions.Pages_TakTikan_FabricCut_Create, L("CreatingNewFabricCut"));
            FabricCut.CreateChildPermission(AppPermissions.Pages_TakTikan_FabricCut_Edit, L("EditingFabricCut"));
            FabricCut.CreateChildPermission(AppPermissions.Pages_TakTikan_FabricCut_Delete, L("DeletingFabricCut"));

            var FabricMaterial = taktikan.CreateChildPermission(AppPermissions.Pages_TakTikan_FabricMaterial, L("FabricMaterial"));
            FabricMaterial.CreateChildPermission(AppPermissions.Pages_TakTikan_FabricMaterial_Create, L("CreatingNewFabricMaterial"));
            FabricMaterial.CreateChildPermission(AppPermissions.Pages_TakTikan_FabricMaterial_Edit, L("EditingFabricMaterial"));
            FabricMaterial.CreateChildPermission(AppPermissions.Pages_TakTikan_FabricMaterial_Delete, L("DeletingFabricMaterial"));

            var FabricRoll = taktikan.CreateChildPermission(AppPermissions.Pages_TakTikan_FabricRoll, L("FabricRoll"));
            FabricRoll.CreateChildPermission(AppPermissions.Pages_TakTikan_FabricRoll_Create, L("CreatingNewFabricRoll"));
            FabricRoll.CreateChildPermission(AppPermissions.Pages_TakTikan_FabricRoll_Edit, L("EditingFabricRoll"));
            FabricRoll.CreateChildPermission(AppPermissions.Pages_TakTikan_FabricRoll_Delete, L("DeletingFabricRoll"));

            var FabricType = taktikan.CreateChildPermission(AppPermissions.Pages_TakTikan_FabricType, L("FabricType"));
            FabricType.CreateChildPermission(AppPermissions.Pages_TakTikan_FabricType_Create, L("CreatingNewFabricType"));
            FabricType.CreateChildPermission(AppPermissions.Pages_TakTikan_FabricType_Edit, L("EditingFabricType"));
            FabricType.CreateChildPermission(AppPermissions.Pages_TakTikan_FabricType_Delete, L("DeletingFabricType"));

            var Gender = taktikan.CreateChildPermission(AppPermissions.Pages_TakTikan_Gender, L("Gender"));
            Gender.CreateChildPermission(AppPermissions.Pages_TakTikan_Gender_Create, L("CreatingNewGender"));
            Gender.CreateChildPermission(AppPermissions.Pages_TakTikan_Gender_Edit, L("EditingGender"));
            Gender.CreateChildPermission(AppPermissions.Pages_TakTikan_Gender_Delete, L("DeletingGender"));

            var SalineStone = taktikan.CreateChildPermission(AppPermissions.Pages_TakTikan_SalineStone, L("SalineStone"));
            SalineStone.CreateChildPermission(AppPermissions.Pages_TakTikan_SalineStone_Create, L("CreatingNewSalineStone"));
            SalineStone.CreateChildPermission(AppPermissions.Pages_TakTikan_SalineStone_Edit, L("EditingSalineStone"));
            SalineStone.CreateChildPermission(AppPermissions.Pages_TakTikan_SalineStone_Delete, L("DeletingSalineStone"));

            var SalineStoneOrder = taktikan.CreateChildPermission(AppPermissions.Pages_TakTikan_SalineStoneOrder, L("SalineStoneOrder"));
            SalineStoneOrder.CreateChildPermission(AppPermissions.Pages_TakTikan_SalineStoneOrder_Create, L("CreatingNewSalineStoneOrder"));
            SalineStoneOrder.CreateChildPermission(AppPermissions.Pages_TakTikan_SalineStoneOrder_Edit, L("EditingSalineStoneOrder"));
            SalineStoneOrder.CreateChildPermission(AppPermissions.Pages_TakTikan_SalineStoneOrder_Delete, L("DeletingSalineStoneOrder"));

            var SalineStoneOrderItem = SalineStoneOrder.CreateChildPermission(AppPermissions.Pages_TakTikan_SalineStoneOrderItem, L("SalineStoneOrderItem"));
            SalineStoneOrderItem.CreateChildPermission(AppPermissions.Pages_TakTikan_SalineStoneOrderItem_Create, L("CreatingNewSalineStoneOrderItem"));
            SalineStoneOrderItem.CreateChildPermission(AppPermissions.Pages_TakTikan_SalineStoneOrderItem_Edit, L("EditingSalineStoneOrderItem"));
            SalineStoneOrderItem.CreateChildPermission(AppPermissions.Pages_TakTikan_SalineStoneOrderItem_Delete, L("DeletingSalineStoneOrderItem"));

            var Seamstress = taktikan.CreateChildPermission(AppPermissions.Pages_TakTikan_Seamstress, L("Seamstress"));
            Seamstress.CreateChildPermission(AppPermissions.Pages_TakTikan_Seamstress_Create, L("CreatingNewSeamstress"));
            Seamstress.CreateChildPermission(AppPermissions.Pages_TakTikan_Seamstress_Edit, L("EditingSeamstress"));
            Seamstress.CreateChildPermission(AppPermissions.Pages_TakTikan_Seamstress_Delete, L("DeletingSeamstress"));

            var SewnPiece = taktikan.CreateChildPermission(AppPermissions.Pages_TakTikan_SewnPiece, L("SewnPiece"));
            SewnPiece.CreateChildPermission(AppPermissions.Pages_TakTikan_SewnPiece_Create, L("CreatingNewSewnPiece"));
            SewnPiece.CreateChildPermission(AppPermissions.Pages_TakTikan_SewnPiece_Edit, L("EditingSewnPiece"));
            SewnPiece.CreateChildPermission(AppPermissions.Pages_TakTikan_SewnPiece_Delete, L("DeletingSewnPiece"));
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, TailorConsts.LocalizationSourceName);
        }
    }
}
