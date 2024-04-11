DROP DATABASE IF EXISTS login;
CREATE DATABASE login;

USE login;

CREATE TABLE users (
    id INT AUTO_INCREMENT PRIMARY KEY,
    username VARCHAR(70) NOT NULL,
    password VARCHAR (80) NOT NULL
);

INSERT INTO users (username,password) VALUES ('admin','admin');