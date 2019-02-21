﻿using System.ComponentModel.DataAnnotations;
using Abp.Authorization.Users;

namespace LTMCompanyNameFree.YoyoCmsTemplate.Models.TokenAuth
{
    public class AuthenticateModel
    {
        [Required]
        [StringLength(AbpUserBase.MaxEmailAddressLength)]
        public string UserNameOrEmailAddress { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required]
        [StringLength(AbpUserBase.MaxPlainPasswordLength)]
        public string Password { get; set; }
        
        public bool RememberClient { get; set; }
    }
}
