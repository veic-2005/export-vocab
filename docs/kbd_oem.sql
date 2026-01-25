-- phpMyAdmin SQL Dump
-- version 5.2.3
-- https://www.phpmyadmin.net/
--
-- Host: localhost
-- Generation Time: Jan 25, 2026 at 02:41 PM
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
-- SELECT * FROM `kbd_oem` ORDER BY name DESC, sn;
--

-- --------------------------------------------------------

--
-- Table structure for table `kbd_oem`
--

CREATE TABLE `kbd_oem` (
  `unid` int(11) NOT NULL,
  `name` varchar(8) NOT NULL,
  `vkname` varchar(16) NOT NULL,
  `sn` int(11) NOT NULL COMMENT 'Serial number range: 10~99'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `kbd_oem`
--

INSERT INTO `kbd_oem` (`unid`, `name`, `vkname`, `sn`) VALUES
(1105, 'ur', 'oem_3', 10),
(1093, 'ur', 'oem_4', 11),
(1111, 'ur', 'oem_6', 12),
(1078, 'ur', 'oem_1', 13),
(1108, 'ur', 'oem_7', 14),
(1073, 'ur', 'oem_comma', 15),
(1102, 'ur', 'oem_period', 16),
(1169, 'ur', 'oem_102', 17),
(1105, 'ru', 'oem_3', 10),
(1093, 'ru', 'oem_4', 11),
(1098, 'ru', 'oem_6', 12),
(1078, 'ru', 'oem_1', 13),
(1101, 'ru', 'oem_7', 14),
(1073, 'ru', 'oem_comma', 15),
(1102, 'ru', 'oem_period', 16),
(1077, 'mon', 'oem_minus', 10),
(1097, 'mon', 'oem_plus', 11),
(1082, 'mon', 'oem_4', 12),
(1098, 'mon', 'oem_6', 13),
(1076, 'mon', 'oem_1', 14),
(1087, 'mon', 'oem_7', 15),
(1100, 'mon', 'oem_comma', 16),
(1074, 'mon', 'oem_period', 17),
(1102, 'mon', 'oem_2', 18),
(1094, 'bulg', 'oem_4', 10),
(1084, 'bulg', 'oem_1', 11),
(1095, 'bulg', 'oem_7', 12),
(1088, 'bulg', 'oem_8', 13),
(1083, 'bulg', 'oem_q', 14),
(1073, 'bulg', 'oem_2', 15),
(1117, 'bulg', 'oem_102', 16);

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
