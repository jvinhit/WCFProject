using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ProjectWCF
{
    // jvinhit@gmail.com
    public class ProductService : IProductService
    {
        ProjetoModeloDBEntities _db;
        public List<Produto> FindAll()
        {
            using (_db = new ProjetoModeloDBEntities())
            {
                _db.Configuration.ProxyCreationEnabled = false;
                List<Produto> productos = _db.Produto.Include("Cliente").ToList();
                return productos;
            }
        }

        public Produto Find(int id)
        {
            using (_db = new ProjetoModeloDBEntities())
            {
                _db.Configuration.ProxyCreationEnabled = false;
                Produto pro = _db.Produto.Single(x => x.ProdutoId.Equals(id));
                return pro;
            }
        }

        public Produto New(Produto produto)
        {
            using (_db = new ProjetoModeloDBEntities())
            {
                _db.Configuration.ProxyCreationEnabled = false;
                _db.Produto.Add(produto);
                _db.SaveChanges();
                return produto;
            }
        }

        public Produto Update(Produto pro)
        {
            using (_db = new ProjetoModeloDBEntities())
            {
                _db.Configuration.ProxyCreationEnabled = false;
                _db.Entry(pro).State = EntityState.Modified;
                _db.SaveChanges();
                return pro;
            }
        }

        public Produto DeleteId(int id)
        {
            using (_db = new ProjetoModeloDBEntities())
            {
                _db.Configuration.ProxyCreationEnabled = false;
                Produto pro = _db.Set<Produto>().Find(id);
                _db.Set<Produto>().Remove(pro);
                _db.SaveChanges();
                return pro;
            }
        }

        public Produto Delete(Produto pro)
        {
            using (_db = new ProjetoModeloDBEntities())
            {
                _db.Configuration.ProxyCreationEnabled = false;
                _db.Set<Produto>().Remove(pro);
                _db.SaveChanges();
                return pro;
            }
        }
    }
}
