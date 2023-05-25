-- b) Liste o nome e a unidade de medida de todos os produtos, cuja unidade de medida é em gramas ou em unidades.

SELECT Nome, UnidadeMedida
FROM produto
WHERE UnidadeMedida IN ('g', 'un');
