-- phpMyAdmin SQL Dump
-- version 5.2.3
-- https://www.phpmyadmin.net/
--
-- Host: localhost
-- Generation Time: Jan 30, 2026 at 09:09 AM
-- Server version: 5.7.44
-- PHP Version: 8.4.17

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: SELECT * FROM `kbd_oem` ORDER BY name DESC, sn;
--

-- --------------------------------------------------------

--
-- Table structure for table `kbd_oem`
--

CREATE TABLE `kbd_oem` (
  `unid` int(11) NOT NULL,
  `name` varchar(8) NOT NULL,
  `vkname` varchar(16) NOT NULL,
  `letter` varchar(2) DEFAULT NULL,
  `sn` int(11) NOT NULL COMMENT 'Serial number range: 10~99'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `kbd_oem`
--

INSERT INTO `kbd_oem` (`unid`, `name`, `vkname`, `letter`, `sn`) VALUES
(1093, 'ur1', 'oem_4', 'х', 10),
(1111, 'ur1', 'oem_6', 'ї', 11),
(1078, 'ur1', 'oem_1', 'ж', 12),
(1108, 'ur1', 'oem_7', 'є', 13),
(1073, 'ur1', 'oem_comma', 'б', 14),
(1102, 'ur1', 'oem_period', 'ю', 15),
(1169, 'ur1', 'oem_102', 'ґ', 16),
(1105, 'ru', 'oem_3', 'ё', 10),
(1093, 'ru', 'oem_4', 'х', 11),
(1098, 'ru', 'oem_6', 'ъ', 12),
(1078, 'ru', 'oem_1', 'ж', 13),
(1101, 'ru', 'oem_7', 'э', 14),
(1073, 'ru', 'oem_comma', 'б', 15),
(1102, 'ru', 'oem_period', 'ю', 16);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `kbd_oem`
--
ALTER TABLE `kbd_oem`
  ADD PRIMARY KEY (`unid`,`name`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
