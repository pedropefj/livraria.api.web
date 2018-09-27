# livraria.api.web
LIVROS
GET /livros
GET /livros/{idLivro}
POST /livros
GET /livros/comentarios
GET /livros/{idLivro}/comentarios
GET /livros/{idLivro}/comentarios/{idComentario}
POST /livros/{idLivro}/comentarios
GET /livros?key=&value=

AUTORES
GET /autores
GET /autores/{idAutor}
POST /autores

EDITORAS
GET /editoras
GET /editoras/{idEditora}
POST /editoras

CARRINHO
GET /carrinho
GET /carrinho/{idCarrinho}
POST /carrinho
DELETE /carrinho/{idItem}
DELETE /carrinho

PEDIDOS
GET /pedidos
GET /pedidos/{idPedido}
POST /pedidos
GET /pedidos/{id}/statusEntrega
DELETE /pedidos/{id}
POST /pedidos/{idPedido}/pagamento
