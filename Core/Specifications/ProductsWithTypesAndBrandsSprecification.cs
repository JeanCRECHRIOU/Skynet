using Core.Entities;

namespace Core.Specifications
{
    public class ProductsWithTypesAndBrandsSprecification : BaseSpecifications<Product>
    {
        public ProductsWithTypesAndBrandsSprecification()
        {
            AddInclude(x => x.ProductType);
            AddInclude(x => x.ProductBrand);
        }

        public ProductsWithTypesAndBrandsSprecification(int id) : base(x => x.Id == id)
        {
            AddInclude(x => x.ProductType);
            AddInclude(x => x.ProductBrand);
        }
    }
}