DROP DATABASE IF EXISTS fashion_shop;
CREATE DATABASE fashion_shop;
USE fashion_shop;

CREATE TABLE accounts(
	id INT PRIMARY KEY AUTO_INCREMENT,
    username VARCHAR(255),
    password VARCHAR(255)
);