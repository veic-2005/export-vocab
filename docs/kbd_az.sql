-- phpMyAdmin SQL Dump
-- version 5.2.3
-- https://www.phpmyadmin.net/
--
-- Host: localhost
-- Generation Time: Jan 30, 2026 at 10:06 AM
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
-- https://mariadb.com/docs/server/reference/data-types/string-data-types/character-sets/unicode
-- Basic Latin letters, numbers and punctuation use one byte.
-- European and Middle East letters mostly fit into 2 bytes.
-- Korean, Chinese, and Japanese ideographs use 3-bytes.
--

-- --------------------------------------------------------

--
-- Table structure for table `kbd_az`
--

CREATE TABLE `kbd_az` (
  `id` int(11) NOT NULL,
  `name` varchar(8) NOT NULL,
  `key101` char(1) NOT NULL,
  `letter` varchar(2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `kbd_az`
--

INSERT INTO `kbd_az` (`id`, `name`, `key101`, `letter`) VALUES
(1001, 'ru', 'a', 'ф'),
(1002, 'ru', 'b', 'и'),
(1003, 'ru', 'c', 'с'),
(1004, 'ru', 'd', 'в'),
(1005, 'ru', 'e', 'у'),
(1006, 'ru', 'f', 'а'),
(1007, 'ru', 'g', 'п'),
(1008, 'ru', 'h', 'р'),
(1009, 'ru', 'i', 'ш'),
(1010, 'ru', 'j', 'о'),
(1011, 'ru', 'k', 'л'),
(1012, 'ru', 'l', 'д'),
(1013, 'ru', 'm', 'ь'),
(1014, 'ru', 'n', 'т'),
(1015, 'ru', 'o', 'щ'),
(1016, 'ru', 'p', 'з'),
(1017, 'ru', 'q', 'й'),
(1018, 'ru', 'r', 'к'),
(1019, 'ru', 's', 'ы'),
(1020, 'ru', 't', 'е'),
(1021, 'ru', 'u', 'г'),
(1022, 'ru', 'v', 'м'),
(1023, 'ru', 'w', 'ц'),
(1024, 'ru', 'x', 'ч'),
(1025, 'ru', 'y', 'н'),
(1026, 'ru', 'z', 'я');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `kbd_az`
--
ALTER TABLE `kbd_az`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `kbd_az`
--
ALTER TABLE `kbd_az`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=1027;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
