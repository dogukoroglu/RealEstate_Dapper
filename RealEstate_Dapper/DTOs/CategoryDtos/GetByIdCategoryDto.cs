﻿namespace RealEstate_Dapper.DTOs.CategoryDtos
{
    public class GetByIdCategoryDto
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public bool CategoryStatus { get; set; }
    }
}
