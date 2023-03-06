using ElectroECommerce.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ElectroECommerce.Application.Models
{
    public static class BaseEntityExtension
    {
        public static void SetCreateInfo(this BaseEntity baseEntity, string userName)
        {
            baseEntity.CreatedBy = userName;
            baseEntity.CreatedAt = DateTime.Now;
        }

        public static void SetUpdateInfo(this BaseEntity baseEntity, string userName)
        {
            baseEntity.CreatedBy = userName;
            baseEntity.CreatedAt = DateTime.Now;
        }
    }
}
