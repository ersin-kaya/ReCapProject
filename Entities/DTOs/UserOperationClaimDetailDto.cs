﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class UserOperationClaimDetailDto : IDto
    {
        public int OperationClaimId { get; set; }
        public string OperationClaimName { get; set; }
    }
}
