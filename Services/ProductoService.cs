using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PC4.Models;

namespace PC4.Services
{
    public class ProductoService
    {
        public List<Producto> getTrendingProductos() {
            List<Producto> result = new List<Producto>
            {
                new Producto { ProductoId = 1, ProductoNombre = "Dune: Part Two" },
                new Producto { ProductoId = 2, ProductoNombre = "Furiosa: A Mad Max Saga" },
                new Producto { ProductoId = 3, ProductoNombre = "Kingdom of the Planet of the Apes" }
            };

            return result;
        }
        public List<Producto> getAllProductos() {
            List<Producto> result = new List<Producto>
            {
                new Producto { ProductoId = 1, ProductoNombre = "Dune: Part Two " },
                new Producto { ProductoId = 2, ProductoNombre = "Furiosa: A Mad Max Saga" },
                new Producto { ProductoId = 3, ProductoNombre = "Kingdom of the Planet of the Apes" },
                new Producto { ProductoId = 4, ProductoNombre = "The Garfield Movie" },
                new Producto { ProductoId = 5, ProductoNombre = "In A Violent Nature" },
                new Producto { ProductoId = 6, ProductoNombre = "Civil War" },
                new Producto { ProductoId = 7, ProductoNombre = "Kung Fu Panda 4" },
                new Producto { ProductoId = 8, ProductoNombre = "Ezra" },
                new Producto { ProductoId = 9, ProductoNombre = "Evil Does Not Exist" },
                new Producto { ProductoId = 10, ProductoNombre = "Challengers" }
            };

            return result;
        }

    }
}
