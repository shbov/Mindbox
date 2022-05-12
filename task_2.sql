
CREATE TABLE "categories" ("id" integer,"name" text NOT NULL DEFAULT NULL, PRIMARY KEY (id));

CREATE TABLE product_category (
	product_id INTEGER,
	category_id INTEGER,
	FOREIGN KEY (product_id) REFERENCES products (id),
	FOREIGN KEY (category_id) REFERENCES categories (id),
	PRIMARY KEY (product_id, category_id)
);

CREATE TABLE "products" ("id" integer DEFAULT '',"name" text, PRIMARY KEY (id));

INSERT INTO "categories" ("id", "name") VALUES
('1', 'Category #1'),
('2', 'Category #2');

INSERT INTO "product_category" ("product_id", "category_id") VALUES
('1', '1'),
('1', '2'),
('3', '1');

INSERT INTO "products" ("id", "name") VALUES
('1', 'Product #1'),
('2', 'Product #2'),
('3', 'Product #3');

SELECT
	products.name,
	categories.name
FROM
	products
	LEFT JOIN product_category ON product_category.product_id = products.id
	LEFT JOIN categories ON product_category.category_id = categories.id;