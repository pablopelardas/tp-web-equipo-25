Create Procedure SP_ListarMarcas
as
Select Id, Descripcion From MARCAS
Go

Exec SP_ListarMarcas
Go

Create Procedure SP_ListarCategorias
as
Select Id, Descripcion From CATEGORIAS
Go

Exec SP_ListarCategorias
Go

Create Procedure SP_ListarArticulos
as
select a.Id, Codigo, Nombre, a.Descripcion as Descripcion,m.Id as IdMarca, m.Descripcion as Marca, c.Id as IdCategoria , c.Descripcion as Categoria, Precio from ARTICULOS a left join MARCAS m on a.IdMarca = m.Id left join CATEGORIAS c on a.IdCategoria = c.Id
Go

Exec SP_ListarArticulos
Go
