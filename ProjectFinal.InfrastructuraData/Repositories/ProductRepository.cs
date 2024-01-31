using ProjectFinal.Domain.Entities;
using ProjectFinal.Domain.Repository;
using ProjectFinal.InfrastructuraData.Data;

namespace ProjectFinal.InfrastructuraData.Repositories
{
    public class ProductRepository : GenericRepository<ProductEntity>, IProductRepository
    {
        public ProductRepository(DataContext context) : base(context)
        {            
        }

        public void LogicDelete(ProductEntity entity)
        {
            var entityFound = GetById(x => x.Id == entity.Id) ?? throw new Exception("Producto no encontrado");

            entityFound.IsDeleted = true;
            Update(entity);
        }
    }
}
