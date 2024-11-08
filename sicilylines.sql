-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1
-- Généré le : ven. 08 nov. 2024 à 10:19
-- Version du serveur : 10.4.32-MariaDB
-- Version de PHP : 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `sicilylines`
--

-- --------------------------------------------------------

--
-- Structure de la table `bateau`
--

CREATE TABLE `bateau` (
  `IDBATEAU` int(11) NOT NULL,
  `NOM` char(32) DEFAULT NULL,
  `LONGUEUR` decimal(10,2) DEFAULT NULL,
  `LARGEUR` decimal(10,2) DEFAULT NULL,
  `VITESSE` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `bateau`
--

INSERT INTO `bateau` (`IDBATEAU`, `NOM`, `LONGUEUR`, `LARGEUR`, `VITESSE`) VALUES
(1, 'L\'Express', 100.50, 20.30, 25),
(2, 'Le Rapide', 110.75, 22.00, 30);

-- --------------------------------------------------------

--
-- Structure de la table `categorie`
--

CREATE TABLE `categorie` (
  `IDCATEGORIE` int(11) NOT NULL,
  `LIBELLE` char(32) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `categorie`
--

INSERT INTO `categorie` (`IDCATEGORIE`, `LIBELLE`) VALUES
(1, 'Economique'),
(2, 'Business'),
(3, 'Première classe');

-- --------------------------------------------------------

--
-- Structure de la table `client`
--

CREATE TABLE `client` (
  `IDCLIENT` int(11) NOT NULL,
  `CP` int(11) DEFAULT NULL,
  `ADRESSE` char(32) DEFAULT NULL,
  `VILLE` char(32) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `client`
--

INSERT INTO `client` (`IDCLIENT`, `CP`, `ADRESSE`, `VILLE`) VALUES
(1, 75001, '12 Rue de la Paix', 'Paris'),
(2, 13008, '5 Boulevard Michelet', 'Marseille');

-- --------------------------------------------------------

--
-- Structure de la table `contenir`
--

CREATE TABLE `contenir` (
  `IDBATEAU` int(11) NOT NULL,
  `IDCATEGORIE` int(11) NOT NULL,
  `CAPACITEMAX` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `contenir`
--

INSERT INTO `contenir` (`IDBATEAU`, `IDCATEGORIE`, `CAPACITEMAX`) VALUES
(1, 1, 150),
(1, 2, 50),
(2, 1, 100),
(2, 3, 20);

-- --------------------------------------------------------

--
-- Structure de la table `equipement`
--

CREATE TABLE `equipement` (
  `IDEQUIPEMENT` int(11) NOT NULL,
  `LIBELLE` char(32) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `equipement`
--

INSERT INTO `equipement` (`IDEQUIPEMENT`, `LIBELLE`) VALUES
(1, 'Restaurant'),
(2, 'Piscine'),
(3, 'Wi-Fi');

-- --------------------------------------------------------

--
-- Structure de la table `liaison`
--

CREATE TABLE `liaison` (
  `IDLIAISON` int(11) NOT NULL,
  `IDSECTEUR` int(11) NOT NULL,
  `IDPORTDEPART` int(11) NOT NULL,
  `IDPORTARRIVEE` int(11) NOT NULL,
  `DUREE` time DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `liaison`
--

INSERT INTO `liaison` (`IDLIAISON`, `IDSECTEUR`, `IDPORTDEPART`, `IDPORTARRIVEE`, `DUREE`) VALUES
(1, 1, 1, 3, '03:30:00'),
(2, 2, 2, 4, '05:00:00');

-- --------------------------------------------------------

--
-- Structure de la table `periode`
--

CREATE TABLE `periode` (
  `IDPERIODE` int(11) NOT NULL,
  `DATEDEBUT` date DEFAULT NULL,
  `DATEFIN` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `periode`
--

INSERT INTO `periode` (`IDPERIODE`, `DATEDEBUT`, `DATEFIN`) VALUES
(1, '2024-06-01', '2024-06-30'),
(2, '2024-07-01', '2024-07-31');

-- --------------------------------------------------------

--
-- Structure de la table `port`
--

CREATE TABLE `port` (
  `IDPORT` int(11) NOT NULL,
  `NOM` char(32) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `port`
--

INSERT INTO `port` (`IDPORT`, `NOM`) VALUES
(1, 'Port de Marseille'),
(2, 'Port de Nice'),
(3, 'Port de Bastia'),
(4, 'Port de Civitavecchia');

-- --------------------------------------------------------

--
-- Structure de la table `proposer`
--

CREATE TABLE `proposer` (
  `IDBATEAU` int(11) NOT NULL,
  `IDEQUIPEMENT` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `proposer`
--

INSERT INTO `proposer` (`IDBATEAU`, `IDEQUIPEMENT`) VALUES
(1, 1),
(1, 2),
(2, 1),
(2, 3);

-- --------------------------------------------------------

--
-- Structure de la table `reservation`
--

CREATE TABLE `reservation` (
  `IDRESERVATION` int(11) NOT NULL,
  `IDLIAISON` int(11) NOT NULL,
  `IDTRAVERSEE` int(11) NOT NULL,
  `IDCLIENT` int(11) NOT NULL,
  `RECAPITULATIF` char(32) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `reservation`
--

INSERT INTO `reservation` (`IDRESERVATION`, `IDLIAISON`, `IDTRAVERSEE`, `IDCLIENT`, `RECAPITULATIF`) VALUES
(1, 1, 1, 1, 'Réservation client 1 pour la tra'),
(2, 2, 2, 2, 'Réservation client 2 pour la tra');

-- --------------------------------------------------------

--
-- Structure de la table `secteur`
--

CREATE TABLE `secteur` (
  `IDSECTEUR` int(11) NOT NULL,
  `LIBELLE` char(32) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `secteur`
--

INSERT INTO `secteur` (`IDSECTEUR`, `LIBELLE`) VALUES
(1, 'Secteur Nord'),
(2, 'Secteur Sud');

-- --------------------------------------------------------

--
-- Structure de la table `selectionner`
--

CREATE TABLE `selectionner` (
  `IDTYPE` int(11) NOT NULL,
  `IDRESERVATION` int(11) NOT NULL,
  `QUANTITE` char(32) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `selectionner`
--

INSERT INTO `selectionner` (`IDTYPE`, `IDRESERVATION`, `QUANTITE`) VALUES
(1, 1, '2'),
(2, 2, '1');

-- --------------------------------------------------------

--
-- Structure de la table `tarifier`
--

CREATE TABLE `tarifier` (
  `IDLIAISON` int(11) NOT NULL,
  `IDPERIODE` int(11) NOT NULL,
  `IDTYPE` int(11) NOT NULL,
  `TARIF` decimal(13,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `tarifier`
--

INSERT INTO `tarifier` (`IDLIAISON`, `IDPERIODE`, `IDTYPE`, `TARIF`) VALUES
(1, 1, 1, 100.50),
(1, 2, 2, 75.00),
(2, 1, 3, 25.00);

-- --------------------------------------------------------

--
-- Structure de la table `traversee`
--

CREATE TABLE `traversee` (
  `IDLIAISON` int(11) NOT NULL,
  `IDTRAVERSEE` int(11) NOT NULL,
  `IDBATEAU` int(11) NOT NULL,
  `DATETRAVERSEE` date DEFAULT NULL,
  `HEURE` time DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `traversee`
--

INSERT INTO `traversee` (`IDLIAISON`, `IDTRAVERSEE`, `IDBATEAU`, `DATETRAVERSEE`, `HEURE`) VALUES
(1, 1, 1, '2024-07-15', '09:00:00'),
(2, 2, 2, '2024-07-16', '14:00:00');

-- --------------------------------------------------------

--
-- Structure de la table `type`
--

CREATE TABLE `type` (
  `IDTYPE` int(11) NOT NULL,
  `IDCATEGORIE` int(11) NOT NULL,
  `LIBELLE` char(32) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `type`
--

INSERT INTO `type` (`IDTYPE`, `IDCATEGORIE`, `LIBELLE`) VALUES
(1, 1, 'Voiture'),
(2, 2, 'Moto'),
(3, 3, 'Vélo');

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `bateau`
--
ALTER TABLE `bateau`
  ADD PRIMARY KEY (`IDBATEAU`);

--
-- Index pour la table `categorie`
--
ALTER TABLE `categorie`
  ADD PRIMARY KEY (`IDCATEGORIE`);

--
-- Index pour la table `client`
--
ALTER TABLE `client`
  ADD PRIMARY KEY (`IDCLIENT`);

--
-- Index pour la table `contenir`
--
ALTER TABLE `contenir`
  ADD PRIMARY KEY (`IDBATEAU`,`IDCATEGORIE`),
  ADD KEY `I_FK_CONTENIR_BATEAU` (`IDBATEAU`),
  ADD KEY `I_FK_CONTENIR_CATEGORIE` (`IDCATEGORIE`);

--
-- Index pour la table `equipement`
--
ALTER TABLE `equipement`
  ADD PRIMARY KEY (`IDEQUIPEMENT`);

--
-- Index pour la table `liaison`
--
ALTER TABLE `liaison`
  ADD PRIMARY KEY (`IDLIAISON`),
  ADD KEY `I_FK_LIAISON_SECTEUR` (`IDSECTEUR`),
  ADD KEY `I_FK_LIAISON_PORT` (`IDPORTDEPART`),
  ADD KEY `I_FK_LIAISON_PORT1` (`IDPORTARRIVEE`);

--
-- Index pour la table `periode`
--
ALTER TABLE `periode`
  ADD PRIMARY KEY (`IDPERIODE`);

--
-- Index pour la table `port`
--
ALTER TABLE `port`
  ADD PRIMARY KEY (`IDPORT`);

--
-- Index pour la table `proposer`
--
ALTER TABLE `proposer`
  ADD PRIMARY KEY (`IDBATEAU`,`IDEQUIPEMENT`),
  ADD KEY `I_FK_PROPOSER_BATEAU` (`IDBATEAU`),
  ADD KEY `I_FK_PROPOSER_EQUIPEMENT` (`IDEQUIPEMENT`);

--
-- Index pour la table `reservation`
--
ALTER TABLE `reservation`
  ADD PRIMARY KEY (`IDRESERVATION`),
  ADD KEY `I_FK_RESERVATION_TRAVERSEE` (`IDLIAISON`,`IDTRAVERSEE`),
  ADD KEY `I_FK_RESERVATION_CLIENT` (`IDCLIENT`);

--
-- Index pour la table `secteur`
--
ALTER TABLE `secteur`
  ADD PRIMARY KEY (`IDSECTEUR`);

--
-- Index pour la table `selectionner`
--
ALTER TABLE `selectionner`
  ADD PRIMARY KEY (`IDTYPE`,`IDRESERVATION`),
  ADD KEY `I_FK_SELECTIONNER_TYPE` (`IDTYPE`),
  ADD KEY `I_FK_SELECTIONNER_RESERVATION` (`IDRESERVATION`);

--
-- Index pour la table `tarifier`
--
ALTER TABLE `tarifier`
  ADD PRIMARY KEY (`IDLIAISON`,`IDPERIODE`,`IDTYPE`),
  ADD KEY `I_FK_TARIFIER_LIAISON` (`IDLIAISON`),
  ADD KEY `I_FK_TARIFIER_PERIODE` (`IDPERIODE`),
  ADD KEY `I_FK_TARIFIER_TYPE` (`IDTYPE`);

--
-- Index pour la table `traversee`
--
ALTER TABLE `traversee`
  ADD PRIMARY KEY (`IDLIAISON`,`IDTRAVERSEE`),
  ADD KEY `I_FK_TRAVERSEE_LIAISON` (`IDLIAISON`),
  ADD KEY `I_FK_TRAVERSEE_BATEAU` (`IDBATEAU`);

--
-- Index pour la table `type`
--
ALTER TABLE `type`
  ADD PRIMARY KEY (`IDTYPE`),
  ADD KEY `I_FK_TYPE_CATEGORIE` (`IDCATEGORIE`);

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `contenir`
--
ALTER TABLE `contenir`
  ADD CONSTRAINT `FK_CONTENIR_BATEAU` FOREIGN KEY (`IDBATEAU`) REFERENCES `bateau` (`IDBATEAU`),
  ADD CONSTRAINT `FK_CONTENIR_CATEGORIE` FOREIGN KEY (`IDCATEGORIE`) REFERENCES `categorie` (`IDCATEGORIE`);

--
-- Contraintes pour la table `liaison`
--
ALTER TABLE `liaison`
  ADD CONSTRAINT `FK_LIAISON_PORT` FOREIGN KEY (`IDPORTDEPART`) REFERENCES `port` (`IDPORT`),
  ADD CONSTRAINT `FK_LIAISON_PORT1` FOREIGN KEY (`IDPORTARRIVEE`) REFERENCES `port` (`IDPORT`),
  ADD CONSTRAINT `FK_LIAISON_SECTEUR` FOREIGN KEY (`IDSECTEUR`) REFERENCES `secteur` (`IDSECTEUR`);

--
-- Contraintes pour la table `proposer`
--
ALTER TABLE `proposer`
  ADD CONSTRAINT `FK_PROPOSER_BATEAU` FOREIGN KEY (`IDBATEAU`) REFERENCES `bateau` (`IDBATEAU`),
  ADD CONSTRAINT `FK_PROPOSER_EQUIPEMENT` FOREIGN KEY (`IDEQUIPEMENT`) REFERENCES `equipement` (`IDEQUIPEMENT`);

--
-- Contraintes pour la table `reservation`
--
ALTER TABLE `reservation`
  ADD CONSTRAINT `FK_RESERVATION_CLIENT` FOREIGN KEY (`IDCLIENT`) REFERENCES `client` (`IDCLIENT`),
  ADD CONSTRAINT `FK_RESERVATION_TRAVERSEE` FOREIGN KEY (`IDLIAISON`,`IDTRAVERSEE`) REFERENCES `traversee` (`IDLIAISON`, `IDTRAVERSEE`);

--
-- Contraintes pour la table `selectionner`
--
ALTER TABLE `selectionner`
  ADD CONSTRAINT `FK_SELECTIONNER_RESERVATION` FOREIGN KEY (`IDRESERVATION`) REFERENCES `reservation` (`IDRESERVATION`),
  ADD CONSTRAINT `FK_SELECTIONNER_TYPE` FOREIGN KEY (`IDTYPE`) REFERENCES `type` (`IDTYPE`);

--
-- Contraintes pour la table `tarifier`
--
ALTER TABLE `tarifier`
  ADD CONSTRAINT `FK_TARIFIER_LIAISON` FOREIGN KEY (`IDLIAISON`) REFERENCES `liaison` (`IDLIAISON`),
  ADD CONSTRAINT `FK_TARIFIER_PERIODE` FOREIGN KEY (`IDPERIODE`) REFERENCES `periode` (`IDPERIODE`),
  ADD CONSTRAINT `FK_TARIFIER_TYPE` FOREIGN KEY (`IDTYPE`) REFERENCES `type` (`IDTYPE`);

--
-- Contraintes pour la table `traversee`
--
ALTER TABLE `traversee`
  ADD CONSTRAINT `FK_TRAVERSEE_BATEAU` FOREIGN KEY (`IDBATEAU`) REFERENCES `bateau` (`IDBATEAU`),
  ADD CONSTRAINT `FK_TRAVERSEE_LIAISON` FOREIGN KEY (`IDLIAISON`) REFERENCES `liaison` (`IDLIAISON`);

--
-- Contraintes pour la table `type`
--
ALTER TABLE `type`
  ADD CONSTRAINT `FK_TYPE_CATEGORIE` FOREIGN KEY (`IDCATEGORIE`) REFERENCES `categorie` (`IDCATEGORIE`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
