-- phpMyAdmin SQL Dump
-- version 4.1.14
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Jun 02, 2015 at 05:19 PM
-- Server version: 5.6.17
-- PHP Version: 5.5.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `kino`
--

-- --------------------------------------------------------

--
-- Table structure for table `film`
--

CREATE TABLE IF NOT EXISTS `film` (
  `id` mediumint(8) unsigned NOT NULL AUTO_INCREMENT,
  `Naziv` text COLLATE utf8_croatian_ci,
  `GodinaIzdavanja` mediumint(9) DEFAULT NULL,
  `Glumac1` varchar(255) COLLATE utf8_croatian_ci DEFAULT NULL,
  `Glumac2` varchar(255) COLLATE utf8_croatian_ci DEFAULT NULL,
  `Reziser` varchar(255) COLLATE utf8_croatian_ci DEFAULT NULL,
  `Zanr` text COLLATE utf8_croatian_ci,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_croatian_ci AUTO_INCREMENT=19 ;

--
-- Dumping data for table `film`
--

INSERT INTO `film` (`id`, `Naziv`, `GodinaIzdavanja`, `Glumac1`, `Glumac2`, `Reziser`, `Zanr`) VALUES
(1, 'Nepobjedivi', 2011, 'Basia Cleveland', 'Grant Stein', 'Gil Gay', 'Aliquam'),
(2, 'Torquent', 2001, 'Warren Horn', 'Byron Herman', 'Renee Scott', 'vitae'),
(3, 'Duis', 2009, 'Emi Roy', 'Cailin Summers', 'Tyler Bell', 'neque.'),
(4, 'Neustrasivi', 1997, 'Randall Miranda', 'Victor Bryant', 'Kennedy Preston', 'imperdiet'),
(5, 'Donec non ', 1996, 'Jason Dominguez', 'Halee Avery', 'Felicia Ellis', 'eu,'),
(6, 'Glup i gluplji', 2013, 'Shellie Harris', 'Zane Rodgers', 'Hyacinth Caldwell', 'nec,'),
(7, 'Sed id', 2012, 'Austin Fuentes', 'Cathleen Daniels', 'Willow Forbes', 'Vestibulum'),
(8, 'Exam', 2001, 'Noble Dean', 'Quinlan Merritt', 'Ruby Russell', 'elit,'),
(9, 'Pharetra', 1996, 'Lois Turner', 'Bertha Guy', 'Lilah Wilson', 'rutrum'),
(10, 'Lavlje srce', 2000, 'Marvin Sanford', 'Raven Rosa', 'Jayme Nelson', 'et'),
(11, 'Odbrana', 1996, 'Brenden Travis', 'Eugenia Conway', 'Zahir Price', 'cursus'),
(12, 'Misionar', 2001, 'Aubrey Carter', 'Grace England', 'Ingrid Haney', 'Etiam'),
(13, 'Brzi i zestoki', 2009, 'Cade Collier', 'Blaze Schneider', 'Jemima Sharp', 'pede,'),
(14, 'The Expendables', 2012, 'Yoshio Foster', 'Noah Webb', 'Vaughan Maldonado', 'lorem,'),
(15, 'Proin veli', 2013, 'Laith Bernard', 'Jakeem Thompson', 'Charlotte Pacheco', 'magnis'),
(16, 'Erat eros', 2011, 'Owen Farmer', 'Dale Pate', 'George Wheeler', 'arcu'),
(17, 'To nisam ja', 1995, 'Jacob Page', 'Adria Dyer', 'Jermaine Marquez', 'Ut'),
(18, 'Risus nulla', 2013, 'Michelle Wiggins', 'Kevin Melendez', 'Kelsie Moran', 'mauris.');

-- --------------------------------------------------------

--
-- Table structure for table `karta`
--

CREATE TABLE IF NOT EXISTS `karta` (
  `id` mediumint(8) unsigned NOT NULL AUTO_INCREMENT,
  `Film` text COLLATE utf8_croatian_ci,
  `RezervacijskiBroj` int(11) DEFAULT NULL,
  `Sala` mediumint(9) DEFAULT NULL,
  `BrojSjedista` mediumint(9) DEFAULT NULL,
  `Termin` text COLLATE utf8_croatian_ci,
  `Cijena` mediumint(9) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_croatian_ci AUTO_INCREMENT=20 ;

--
-- Dumping data for table `karta`
--

INSERT INTO `karta` (`id`, `Film`, `RezervacijskiBroj`, `Sala`, `BrojSjedista`, `Termin`, `Cijena`) VALUES
(1, 'Nepobjedivi', 25, 5, 3, 'Morbi', 5),
(2, 'Torquent', 12, 2, 22, 'molestie.', 4),
(3, 'Duis', 1, 2, 3, 'Curabitur', 5),
(4, 'Neustrasivi', 6, 2, 14, 'augue', 5),
(5, 'Donec non ', 4, 3, 28, 'ac', 7),
(6, 'Glup i gluplji', 9, 3, 17, 'vestibulum', 6),
(7, 'Sed id', 9, 2, 18, 'eget,', 7),
(8, 'Exam', 18, 2, 29, 'Morbi', 5),
(9, 'Pharetra', 19, 3, 18, 'vulputate', 4),
(10, 'Lavlje srce', 6, 1, 23, 'mi', 4),
(11, 'Odbrana', 7, 1, 10, 'dolor.', 4),
(12, 'Misionar', 7, 3, 14, 'Duis', 5),
(13, 'Brzi i zestoki', 1, 3, 12, 'ultrices,', 4),
(14, 'The Expendables', 2, 1, 17, 'magna.', 6),
(15, 'Proin veli', 5, 3, 5, 'dapibus', 4),
(16, 'Erat eros', 1, 5, 4, 'vitae,', 6),
(17, 'To nisam ja', 3, 4, 13, 'ac', 6),
(18, 'Risus nulla', 7, 2, 6, 'egestas', 5),
(19, 'Pharetra', 5, 3, 52, 'vulputate', 4);

-- --------------------------------------------------------

--
-- Table structure for table `klijent`
--

CREATE TABLE IF NOT EXISTS `klijent` (
  `id` mediumint(8) unsigned NOT NULL AUTO_INCREMENT,
  `ImePrezime` varchar(255) COLLATE utf8_croatian_ci DEFAULT NULL,
  `BrojLicneKarte` varchar(255) COLLATE utf8_croatian_ci DEFAULT NULL,
  `BrojKinoKartice` mediumint(9) DEFAULT NULL,
  `BrojStudentKinoKartice` mediumint(9) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_croatian_ci AUTO_INCREMENT=101 ;

--
-- Dumping data for table `klijent`
--

INSERT INTO `klijent` (`id`, `ImePrezime`, `BrojLicneKarte`, `BrojKinoKartice`, `BrojStudentKinoKartice`) VALUES
(1, 'Darius Landry', '7EDZBKMJA', 1, 18747),
(2, 'Brett Humphrey', '9CCNGXBMX', 2, 13439),
(3, 'Kermit Cannon', '2SUSOKFXD', 3, 12599),
(4, 'Tiger Burks', '6NUZUWSIV', 4, 14788),
(5, 'Salvador Shelton', '6SYMTMMGS', 5, 16055),
(6, 'Abbot Dillon', '9SDEHOEKU', 6, 14680),
(7, 'Clarke Aguirre', '8ZYPMDRLG', 7, 10035),
(8, 'Hamish Rosales', '8WGOMVFKS', 8, 13217),
(9, 'Paki Lara', '6DIPDLTSE', 9, 13116),
(10, 'Mark Foster', '7PWJDLAMQ', 10, 16447),
(11, 'Yardley Turner', '9AUCLBPGJ', 11, 11860),
(12, 'Silas Vargas', '0QLIZWSUE', 12, 16711),
(13, 'Avram Mueller', '1SYKTODUD', 13, 19313),
(14, 'Erasmus Mckinney', '0ZDVBPCKJ', 14, 11380),
(15, 'Amos Hines', '8JDZCKLSA', 15, 14690),
(16, 'Rahim Mcclure', '3HLIOTQXM', 16, 12049),
(17, 'Adrian Mercer', '4DQZNPLAV', 17, 19822),
(18, 'Aristotle Steele', '0OLHVJBVT', 18, 17000),
(19, 'Oren Wilkerson', '6PKBZVTCE', 19, 19964),
(20, 'Baxter Ingram', '1HJZDBUTY', 20, 14289),
(21, 'Walker Randall', '1TSYNDPIK', 21, 15434),
(22, 'Denton Ramirez', '6FQVXCAIQ', 22, 12544),
(23, 'Lyle Perkins', '0JJIGJSRM', 23, 14122),
(24, 'Kevin Hewitt', '6HTSYAYIF', 24, 15868),
(25, 'Tyler Reed', '4OLLUKEHF', 25, 15946),
(26, 'Valentine Beasley', '8LUSQOCXN', 26, 11275),
(27, 'Harper Hernandez', '3POSWXOOG', 27, 14184),
(28, 'Jerome Mccoy', '2WBPDWRFS', 28, 15736),
(29, 'Ethan Velasquez', '0URXCBTZF', 29, 19759),
(30, 'Brennan English', '6CODHSCFJ', 30, 14193),
(31, 'Armand Frederick', '7EPPSTEGU', 31, 14723),
(32, 'Phelan Estrada', '5FZLPVCZX', 32, 13034),
(33, 'Oren Walls', '8NIZJZYYZ', 33, 15295),
(34, 'Forrest Townsend', '3KTQABDKI', 34, 19334),
(35, 'Zeus Logan', '0UUBWVITM', 35, 19088),
(36, 'Garrison Alvarez', '9HNSZSUSP', 36, 14531),
(37, 'Conan Roberson', '0HQRCRMRB', 37, 10104),
(38, 'Chester Cotton', '8ZBDSCAYJ', 38, 11308),
(39, 'Tad Dickerson', '4VSDPMOPM', 39, 15510),
(40, 'Rajah Bonner', '0UCYKJMMY', 40, 15509),
(41, 'Hedley Hickman', '6YTCVVXCM', 41, 14094),
(42, 'Geoffrey Lang', '7KABVVZSF', 42, 16810),
(43, 'Jameson Watson', '1IDUJUGDB', 43, 18958),
(44, 'Wesley Trevino', '1QNSPYKYX', 44, 15825),
(45, 'Hedley Walker', '4EDWFCWPL', 45, 12261),
(46, 'Otto Gill', '3PGZOYAOE', 46, 14748),
(47, 'Ishmael Allison', '5XRZFTFWS', 47, 19069),
(48, 'Reuben Phelps', '9MMZOOTJM', 48, 14057),
(49, 'Alfonso Floyd', '4BBRALFUK', 49, 15285),
(50, 'Dominic Blankenship', '1FEMYHIZY', 50, 15070),
(51, 'Clinton Lyons', '2OFQGFWMB', 51, 11258),
(52, 'Chaim Reyes', '8ETVGWRSW', 52, 14710),
(53, 'Lawrence Avery', '6ZMEVCGKI', 53, 14541),
(54, 'Joel Byers', '3LIFJYXRF', 54, 16561),
(55, 'Gil Blake', '4CUUFBITF', 55, 18377),
(56, 'Simon Wynn', '6ECGPKBMY', 56, 14372),
(57, 'Samson Sutton', '3ELBCHYSA', 57, 10814),
(58, 'Thane Hensley', '6GQFDFYSX', 58, 16381),
(59, 'Zachary Beard', '0ODOFPZVG', 59, 15457),
(60, 'Allistair Key', '3XQLTMIGM', 60, 10052),
(61, 'Omar Buckley', '7PHSCPZHO', 61, 14642),
(62, 'Lucian Mckay', '9MWXMHTFW', 62, 16377),
(63, 'Ian Kane', '4QWUPUWJB', 63, 19595),
(64, 'Camden Livingston', '3WOGRARCF', 64, 18176),
(65, 'Fritz Hardy', '0LXWXXLYJ', 65, 17618),
(66, 'Raja Pate', '8HPUOJRNE', 66, 15568),
(67, 'Thomas Valenzuela', '0YMBYQVJG', 67, 14767),
(68, 'Driscoll Summers', '9UIWGBLRA', 68, 14494),
(69, 'Leo Lucas', '1VVQRFAPL', 69, 13716),
(70, 'Hop Hobbs', '6PUQHMKFN', 70, 18093),
(71, 'Mason Robles', '1NQHNMJXX', 71, 14964),
(72, 'Eric French', '2TQWFIWJT', 72, 13348),
(73, 'Carson Travis', '7JJRBUYVM', 73, 12448),
(74, 'Blaze Bolton', '8VFLYTNQB', 74, 18620),
(75, 'Brennan Mcclure', '2NGTMYPHE', 75, 10084),
(76, 'Roth Donovan', '0KAFWTNLD', 76, 14659),
(77, 'Seth Anderson', '8EUVXSMAL', 77, 18860),
(78, 'Rooney Martinez', '9NRNGFUMZ', 78, 17275),
(79, 'Logan Nolan', '7XDGLHPJV', 79, 16680),
(80, 'Amos Barlow', '7EYLSBNBA', 80, 19406),
(81, 'Chaney Bonner', '9XFKQWBTA', 81, 17200),
(82, 'Clayton Lowe', '0FIONAFKE', 82, 10727),
(83, 'Chadwick Woodward', '1RGAVNDDK', 83, 16750),
(84, 'Harrison French', '3GHXTLTHE', 84, 11283),
(85, 'Jacob Bradford', '1DSBCKMUB', 85, 14639),
(86, 'Vance Bradshaw', '9ARXJONGO', 86, 10402),
(87, 'Jack Huffman', '1TOKBDZJN', 87, 10276),
(88, 'Dalton Johns', '1WFRDDVTR', 88, 10982),
(89, 'Caesar Mills', '7OUKXNOCC', 89, 18527),
(90, 'Demetrius Mcgee', '2FFUENROI', 90, 11772),
(91, 'Berk Gallegos', '4NMBSQZZR', 91, 12750),
(92, 'Neville Cline', '8LRBCZSPQ', 92, 10816),
(93, 'Merritt Vance', '7XNJSFDDV', 93, 15564),
(94, 'Cyrus Brown', '2GBVTZLBH', 94, 15351),
(95, 'Reed Cook', '1LYAIVPKC', 95, 16426),
(96, 'Grant Bentley', '0EKGTUBUW', 96, 12244),
(97, 'Baxter Bryant', '0XSUSWWIA', 97, 15909),
(98, 'Hyatt Fitzgerald', '3DRLWDXLE', 98, 16163),
(99, 'Xanthus Castillo', '6SOQSWBTK', 99, 11752);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
