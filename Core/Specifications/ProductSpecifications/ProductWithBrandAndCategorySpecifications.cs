using Core.Entities.Product_Entities;

namespace Core.Specifications.ProductSpecifications
{
    public class ProductWithBrandAndCategorySpecifications: BaseSpecification<Product>
    {
        public ProductWithBrandAndCategorySpecifications(ProductSpecificationParameters specParams)
        {
            IncludesCriteria.Add(p => p.Brand);
            IncludesCriteria.Add(p => p.Category);
            WhereCriteria =
               p => (string.IsNullOrEmpty(specParams.search) || p.Name.ToLower().Contains(specParams.search.ToLower())) &&
               (!specParams.brandId.HasValue || p.BrandId == specParams.brandId.Value) &&
               (!specParams.categoryId.HasValue || p.CategoryId == specParams.categoryId.Value);
        }
        public ProductWithBrandAndCategorySpecifications(int id)
        {
            WhereCriteria = p => p.Id == id;
            IncludesCriteria.Add(p => p.Brand);
            IncludesCriteria.Add(p => p.Category);
        }
    }
}