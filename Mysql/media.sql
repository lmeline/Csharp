DROP DATABASE IF EXISTS media;
CREATE DATABASE media;
USE media;

-- Table: langues    
CREATE TABLE langues(
   id BIGINT PRIMARY KEY AUTO_INCREMENT,
   iso3 VARCHAR(3) NOT NULL,
   langue VARCHAR(50) NOT NULL
);
INSERT INTO langues (iso3, langue)
VALUES
    ('fra', 'Français'),
    ('eng', 'Anglais'),
    ('deu', 'Allemand'),
    ('ita', 'Italien'),
    ('esp', 'Espagnol'),
    ('por', 'Portugais'),
    ('nld', 'Néerlandais'),
    ('rus', 'Russe'),
    ('jpn', 'Japonais'),
    ('kor', 'Coréen');
-- Table: code_postal_villes
CREATE TABLE code_postal_villes (
   id BIGINT PRIMARY KEY AUTO_INCREMENT,
   code_postal VARCHAR(15) NOT NULL,
   ville VARCHAR(70) NOT NULL,
   UNIQUE (code_postal, ville)
);
INSERT INTO code_postal_villes (code_postal, ville)
VALUES
('75001', 'Paris'),
('69002', 'Lyon'),
('69006', 'Lyon'),
('33000', 'Bordeaux'),
('13006', 'Marseille'),
('59000', 'Lille'),
('67000', 'Strasbourg'), 
('75011', 'Paris'),
('75013', 'Paris'),
('75002', 'Paris'),
('75008', 'Paris'),
('13001', 'Marseille');



CREATE TABLE types_personnes (
   id BIGINT PRIMARY KEY AUTO_INCREMENT,
   type_personne VARCHAR(50) NOT NULL
);
INSERT INTO types_personnes (type_personne)
VALUES
    ('Adminitrateur'),
    ('Membre'),
    ('Auteur'),
    ('Réalisateur'),
    ('Editeur');

CREATE TABLE personnes(
   id BIGINT PRIMARY KEY AUTO_INCREMENT,
   type_id BIGINT,
   nom VARCHAR(70) NOT NULL,
   prenom VARCHAR(70),
   telephone VARCHAR(20),
   email VARCHAR(70),
   adresse VARCHAR(255),
   code_postal VARCHAR(15),
   ville VARCHAR(70),
   note TEXT,
   date_naissance DATE NOT NULL,
   date_entree DATE,
   date_sortie DATE,
   type_personne_id BIGINT NOT NULL,
   FOREIGN KEY(type_personne_id) REFERENCES types_personnes(id),
   FOREIGN KEY(code_postal, ville) REFERENCES code_postal_villes(code_postal, ville)
);

-- Table: documents
CREATE TABLE documents(
   id BIGINT PRIMARY KEY AUTO_INCREMENT,
   titre VARCHAR(255) NOT NULL,
   auteur_id BIGINT,
   type VARCHAR(50) NOT NULL, 
   genre VARCHAR(50) NOT NULL, 
   collection VARCHAR(70),
   langue_id BIGINT,
   langue_originale_id BIGINT,
   nombre_exemplaires INT,
   tranche_age VARCHAR(50),
   synopsis TEXT,
   FOREIGN KEY(auteur_id) REFERENCES personnes(id),
   FOREIGN KEY(langue_id) REFERENCES langues(id),
   FOREIGN KEY(langue_originale_id) REFERENCES langues(id)
);

-- Table: exemplaires
CREATE TABLE exemplaires(
   id BIGINT PRIMARY KEY AUTO_INCREMENT,
   cote VARCHAR(20) NOT NULL,
   editeur_id BIGINT, 
   fournisseur_id BIGINT, 
   prix DECIMAL(8,2),
   date_acquisition DATE,
   emplacement VARCHAR(70),
   statut VARCHAR(20),  
   etat VARCHAR(20),
   notes TEXT,
   ISBN VARCHAR(13),
   document_id BIGINT,
   FOREIGN KEY(editeur_id) REFERENCES personnes(id),
   FOREIGN KEY(fournisseur_id) REFERENCES personnes(id),
   FOREIGN KEY(document_id) REFERENCES documents(id)
);


INSERT INTO personnes (type_id, nom, prenom, telephone, email, adresse, code_postal, ville, note, date_naissance, date_entree, date_sortie, type_personne_id)
VALUES
  (1, 'Dupont', 'Jean', '0123456789', 'jean.dupont@example.com', '123 Rue de la République', '75001', 'Paris', 'Note pour Jean Dupont', '1990-05-15', '2020-01-01', NULL, 1),
  (2, 'Martin', 'Marie', '0987654321', 'marie.martin@example.com', '456 Avenue des Champs-Élysées', '69002', 'Lyon', 'Note pour Marie Martin', '1985-07-20', '2019-12-15', NULL, 2),
  (3, 'Dubois', 'Pierre', '0234567890', 'pierre.dubois@example.com', '789 Boulevard Saint-Germain', '33000', 'Bordeaux', 'Note pour Pierre Dubois', '1988-10-10', '2020-02-01', NULL, 1),
  (4, 'Leblanc', 'Sophie', '0456789012', 'sophie.leblanc@example.com', '987 Rue de la Paix', '13006', 'Marseille', 'Note pour Sophie Leblanc', '1992-12-25', '2021-01-01', NULL, 2),
  (5, 'Moreau', 'Paul', '0678901234', 'paul.moreau@example.com', '321 Avenue du Maréchal Foch', '59000', 'Lille', 'Note pour Paul Moreau', '1983-04-30', '2019-11-01', '2022-03-15', 1),
  (6, 'Fournier', 'Emilie', '0789012345', 'emilie.fournier@example.com', '654 Rue de la Liberté', '67000', 'Strasbourg', 'Note pour Emilie Fournier', '1995-08-20', '2020-05-01', NULL, 2),
  (7, 'Lefevre', 'Thomas', '0234567890', 'thomas.lefevre@example.com', '852 Boulevard Victor Hugo', '59000', 'Lille', 'Note pour Thomas Lefevre', '1987-09-10', '2019-10-01', NULL, 1),
  (8, 'Girard', 'Julie', '0345678901', 'julie.girard@example.com', '753 Rue du Faubourg Saint-Antoine', '75011', 'Paris', 'Note pour Julie Girard', '1990-11-05', '2021-02-01', NULL, 2),
  (9, 'Andre', 'Sophie', '0456789012', 'sophie.andre@example.com', '159 Avenue des Gobelins', '75013', 'Paris', 'Note pour Sophie Andre', '1982-03-18', '2020-03-01', NULL, 1),
  (10, 'Thomas', 'Lucas', '0567890123', 'lucas.thomas@example.com', '369 Boulevard des Capucines', '75002', 'Paris', 'Note pour Lucas Thomas', '1993-07-22', '2020-04-01', NULL, 2),
  (11, 'Petit', 'Charlotte', '0678901234', 'charlotte.petit@example.com', '456 Rue de Rivoli', '75001', 'Paris', 'Note pour Charlotte Petit', '1985-01-30', '2020-01-01', NULL, 1),
  (12, 'Durand', 'Antoine', '0789012345', 'antoine.durand@example.com', '789 Boulevard Haussmann', '75008', 'Paris', 'Note pour Antoine Durand', '1988-06-12', '2019-11-15', NULL, 2),
  (13, 'Leroy', 'Juliette', '0890123456', 'juliette.leroy@example.com', '963 Avenue des Champs-Élysées', '69006', 'Lyon', 'Note pour Juliette Leroy', '1991-09-05', '2020-02-01', NULL, 1),
  (14, 'Morel', 'Nicolas', '0901234567', 'nicolas.morel@example.com', '258 Rue de la Paix', '13001', 'Marseille', 'Note pour Nicolas Morel', '1986-04-17', '2021-03-01', NULL, 2),
  (15, 'Roux', 'Camille', '0123456789', 'camille.roux@example.com', '741 Avenue de la République', '75011', 'Paris', 'Note pour Camille Roux', '1994-08-28', '2020-04-01', NULL, 1),
  (16, 'Lemoine', 'Alexandre', '0345678901', 'alexandre.lemoine@example.com', '852 Rue du Faubourg Saint-Honoré', '75008', 'Paris', 'Note pour Alexandre Lemoine', '1989-03-15', '2019-12-01', NULL, 2),
  (17, 'Gauthier', 'Manon', '0456789012', 'manon.gauthier@example.com', '159 Avenue des Gobelins', '75013', 'Paris', 'Note pour Manon Gauthier', '1983-11-20', '2020-05-01', NULL, 1),
  (18, 'Leroux', 'Mathilde', '0567890123', 'mathilde.leroux@example.com', '369 Boulevard des Capucines', '75002', 'Paris', 'Note pour Mathilde Leroux', '1996-06-10', '2020-06-01', NULL, 2),
  (19, 'Andre', 'Lucie', '0678901234', 'lucie.andre@example.com', '456 Rue de Rivoli', '75001', 'Paris', 'Note pour Lucie Andre', '1987-02-25', '2019-11-15', NULL, 1),
  (20, 'Meunier', 'Maxime', '0789012345', 'maxime.meunier@example.com', '789 Boulevard Haussmann', '75008', 'Paris', 'Note pour Maxime Meunier', '1990-09-08', '2020-07-01', NULL, 2);


SELECT nom , prenom, type_personne FROM personnes JOIN types_personnes ON types_personnes.id = personnes.type_personne_id  ;

