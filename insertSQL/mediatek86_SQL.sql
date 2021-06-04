-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : ven. 04 juin 2021 à 03:55
-- Version du serveur :  10.4.13-MariaDB
-- Version de PHP : 7.3.21

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `mediatek86`
--

-- --------------------------------------------------------

--
-- Structure de la table `absence`
--

DROP TABLE IF EXISTS `absence`;
CREATE TABLE IF NOT EXISTS `absence` (
  `idpersonnel` int(11) NOT NULL,
  `datedebut` datetime NOT NULL,
  `idmotif` int(11) NOT NULL,
  `datefin` datetime DEFAULT NULL,
  PRIMARY KEY (`idpersonnel`,`datedebut`),
  KEY `FK_absence_motif` (`idmotif`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `absence`
--

INSERT INTO `absence` (`idpersonnel`, `datedebut`, `idmotif`, `datefin`) VALUES
(1, '2019-10-01 00:00:00', 2, '2020-07-17 00:00:00'),
(1, '2020-01-08 00:00:00', 4, '2021-05-01 00:00:00'),
(1, '2020-04-22 00:00:00', 2, '2020-04-23 00:00:00'),
(1, '2020-05-21 00:00:00', 1, '2020-09-05 00:00:00'),
(1, '2020-09-03 00:00:00', 2, '2020-10-30 00:00:00'),
(1, '2021-01-02 00:00:00', 2, '2021-01-25 00:00:00'),
(2, '2019-10-16 00:00:00', 2, '2020-03-20 00:00:00'),
(2, '2019-11-07 00:00:00', 2, '2020-06-08 00:00:00'),
(2, '2019-12-12 00:00:00', 3, '2020-09-25 00:00:00'),
(2, '2020-05-24 00:00:00', 1, '2021-01-27 00:00:00'),
(2, '2020-08-10 00:00:00', 1, '2020-11-28 00:00:00'),
(2, '2020-08-13 00:00:00', 2, '2020-12-09 00:00:00'),
(3, '2019-10-26 00:00:00', 1, '2020-01-04 00:00:00'),
(3, '2020-09-17 00:00:00', 4, '2020-11-28 00:00:00'),
(3, '2021-02-04 00:00:00', 2, '2021-02-18 00:00:00'),
(3, '2021-05-03 00:00:00', 3, '2021-05-06 00:00:00'),
(4, '2019-07-17 00:00:00', 2, '2019-08-29 00:00:00'),
(4, '2019-07-25 00:00:00', 2, '2020-09-21 00:00:00'),
(4, '2019-08-02 00:00:00', 3, '2021-04-18 00:00:00'),
(4, '2019-12-31 00:00:00', 2, '2021-01-18 00:00:00'),
(4, '2020-06-23 00:00:00', 4, '2020-07-17 00:00:00'),
(4, '2020-09-26 00:00:00', 4, '2021-04-24 00:00:00'),
(4, '2020-12-26 00:00:00', 4, '2021-02-24 00:00:00'),
(6, '2019-06-14 00:00:00', 1, '2020-07-04 00:00:00'),
(6, '2019-12-11 00:00:00', 3, '2020-02-07 00:00:00'),
(6, '2020-03-12 00:00:00', 2, '2020-12-27 00:00:00'),
(6, '2020-03-17 00:00:00', 3, '2020-12-20 00:00:00'),
(6, '2021-05-12 00:00:00', 4, '2021-05-29 00:00:00'),
(7, '2019-06-12 00:00:00', 1, '2021-04-22 00:00:00'),
(7, '2019-08-04 00:00:00', 1, '2020-11-26 00:00:00'),
(7, '2019-09-30 00:00:00', 1, '2020-09-13 00:00:00'),
(7, '2019-12-27 00:00:00', 1, '2020-11-07 00:00:00'),
(7, '2019-12-30 00:00:00', 3, '2020-01-07 00:00:00'),
(7, '2020-02-07 00:00:00', 1, '2020-12-21 00:00:00'),
(7, '2020-02-20 00:00:00', 4, '2020-06-20 00:00:00'),
(7, '2021-01-29 00:00:00', 3, '2021-04-25 00:00:00'),
(8, '2019-09-23 00:00:00', 3, '2021-04-27 00:00:00'),
(8, '2019-09-24 00:00:00', 1, '2020-03-06 00:00:00'),
(8, '2019-10-03 00:00:00', 2, '2020-03-17 00:00:00'),
(8, '2019-11-08 00:00:00', 2, '2019-12-10 00:00:00'),
(8, '2019-12-30 00:00:00', 2, '2021-04-09 00:00:00'),
(8, '2020-02-12 00:00:00', 4, '2020-03-05 00:00:00'),
(8, '2021-05-29 00:00:00', 2, '2021-05-29 00:00:00'),
(9, '2020-07-20 00:00:00', 2, '2020-08-31 00:00:00'),
(9, '2021-04-01 00:00:00', 2, '2021-04-03 00:00:00'),
(9, '2021-06-01 00:00:00', 2, '2021-06-03 00:00:00'),
(10, '2021-02-09 00:00:00', 1, '2021-06-25 00:00:00'),
(10, '2021-05-12 00:00:00', 3, '2021-05-29 00:00:00'),
(69, '2021-03-03 00:00:00', 4, '2021-05-27 00:00:00'),
(69, '2021-06-01 00:00:00', 2, '2021-06-04 00:00:00');

-- --------------------------------------------------------

--
-- Structure de la table `motif`
--

DROP TABLE IF EXISTS `motif`;
CREATE TABLE IF NOT EXISTS `motif` (
  `idmotif` int(11) NOT NULL AUTO_INCREMENT,
  `libelle` varchar(128) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`idmotif`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `motif`
--

INSERT INTO `motif` (`idmotif`, `libelle`) VALUES
(1, 'vacances'),
(2, 'maladie'),
(3, 'motif familial'),
(4, 'congé parental');

-- --------------------------------------------------------

--
-- Structure de la table `personnel`
--

DROP TABLE IF EXISTS `personnel`;
CREATE TABLE IF NOT EXISTS `personnel` (
  `idpersonnel` int(11) NOT NULL AUTO_INCREMENT,
  `idservice` int(11) NOT NULL,
  `nom` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  `prenom` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  `tel` varchar(15) COLLATE utf8_unicode_ci DEFAULT NULL,
  `mail` varchar(128) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`idpersonnel`),
  KEY `FK_personnel_service` (`idservice`)
) ENGINE=InnoDB AUTO_INCREMENT=77 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `personnel`
--

INSERT INTO `personnel` (`idpersonnel`, `idservice`, `nom`, `prenom`, `tel`, `mail`) VALUES
(1, 2, 'Odonnell', 'Raja', '07 64 66 20 14', 'Aliquam.erat.volutpat@enim.co.uk'),
(2, 2, 'Hess', 'Rogan', '08 60 51 27 77', 'Nam.nulla.magna@miAliquamgravida.com'),
(3, 3, 'Martin', 'Kelly', '03 01 43 96 21', 'iaculis.quis.pede@sedturpisnec.org'),
(4, 3, 'Gilmore', 'Hugo', '01 60 00 62 27', 'nunc.ac@ac.com'),
(6, 1, 'Cain', 'Akeem', '09 32 07 71 02', 'Duis@malesuadafamesac.ca'),
(7, 3, 'Morin', 'Estere', '09 01 69 32 52', 'molestie.orci@ultriciesadipiscingenim.com'),
(8, 3, 'Funes', 'Charles', '07 60 47 98 10', 'at.risus.Nunc@rhoncusProin.com'),
(9, 3, 'Bass', 'Yuri', '02 88 25 44 22', 'bassyuri@Quisque.co.uk'),
(10, 2, 'Ung', 'Theary', '07 46 27 19 01', 'theary@gmail.com'),
(69, 2, 'Garett', 'Michelle', '07 49 46 27 80', 'garettm@mail.com');

-- --------------------------------------------------------

--
-- Structure de la table `responsable`
--

DROP TABLE IF EXISTS `responsable`;
CREATE TABLE IF NOT EXISTS `responsable` (
  `login` varchar(64) COLLATE utf8_unicode_ci NOT NULL,
  `pwd` varchar(64) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `responsable`
--

INSERT INTO `responsable` (`login`, `pwd`) VALUES
('responsable', '8a96d961c4d8e11918645508fd1d8b484fd847d7c4f7ca630af8cf6fbdead853');

-- --------------------------------------------------------

--
-- Structure de la table `service`
--

DROP TABLE IF EXISTS `service`;
CREATE TABLE IF NOT EXISTS `service` (
  `idservice` int(11) NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`idservice`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `service`
--

INSERT INTO `service` (`idservice`, `nom`) VALUES
(1, 'administratif'),
(2, 'médiation culturelle'),
(3, 'prêt');

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `absence`
--
ALTER TABLE `absence`
  ADD CONSTRAINT `FK_absence_motif` FOREIGN KEY (`idmotif`) REFERENCES `motif` (`idmotif`),
  ADD CONSTRAINT `FK_absence_personnel` FOREIGN KEY (`idpersonnel`) REFERENCES `personnel` (`idpersonnel`);

--
-- Contraintes pour la table `personnel`
--
ALTER TABLE `personnel`
  ADD CONSTRAINT `FK_personnel_service` FOREIGN KEY (`idservice`) REFERENCES `service` (`idservice`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
