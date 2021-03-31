-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Mar 27, 2021 at 07:45 AM
-- Server version: 10.4.17-MariaDB
-- PHP Version: 8.0.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `rekam_medis`
--

-- --------------------------------------------------------

--
-- Table structure for table `tb_admin`
--

CREATE TABLE `tb_admin` (
  `id_admin` int(11) NOT NULL,
  `nama` varchar(100) NOT NULL,
  `username` varchar(100) NOT NULL,
  `password` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tb_admin`
--

INSERT INTO `tb_admin` (`id_admin`, `nama`, `username`, `password`) VALUES
(9, 'muhammad yusuf', 'yusuf', '12345'),
(11, 'affandi', 'affandi', '123');

-- --------------------------------------------------------

--
-- Table structure for table `tb_dokter`
--

CREATE TABLE `tb_dokter` (
  `id_dokter` int(11) NOT NULL,
  `nama` varchar(100) NOT NULL,
  `jk` varchar(20) NOT NULL,
  `spesialis` varchar(100) NOT NULL,
  `username` varchar(100) NOT NULL,
  `password` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tb_dokter`
--

INSERT INTO `tb_dokter` (`id_dokter`, `nama`, `jk`, `spesialis`, `username`, `password`) VALUES
(1, 'Dr. Risqi', 'Laki - laki', 'Umum', 'risqi', 'risqi'),
(2, 'Dr. Intan', 'Perempuan', 'Anak', 'intan', 'intan'),
(5, 'Dr. Indra', 'Laki - laki', 'Kepala', 'indra', 'indra'),
(6, 'Dr. Bowo', 'Laki - Laki', 'Kejiwaan', 'bowo', 'bowo');

-- --------------------------------------------------------

--
-- Table structure for table `tb_obat`
--

CREATE TABLE `tb_obat` (
  `id_obat` int(11) NOT NULL,
  `nama` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tb_obat`
--

INSERT INTO `tb_obat` (`id_obat`, `nama`) VALUES
(1, 'PARACETAMOL 500MG'),
(2, 'PARACETAMOL 250MG'),
(4, 'PANADOL 50MG'),
(5, 'PARAMEX 1000MG'),
(7, 'AMOXILIN 500MG');

-- --------------------------------------------------------

--
-- Table structure for table `tb_pasien`
--

CREATE TABLE `tb_pasien` (
  `id_pasien` int(11) NOT NULL,
  `no_kartu` varchar(100) NOT NULL,
  `nama` varchar(100) NOT NULL,
  `jk` varchar(20) NOT NULL,
  `umur` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tb_pasien`
--

INSERT INTO `tb_pasien` (`id_pasien`, `no_kartu`, `nama`, `jk`, `umur`) VALUES
(9, '112', 'YUSUF', 'Laki - Laki', 15),
(10, '113', 'Deddy', 'Laki - Laki', 40);

-- --------------------------------------------------------

--
-- Table structure for table `tb_rekam_medis`
--

CREATE TABLE `tb_rekam_medis` (
  `id_rekam` int(11) NOT NULL,
  `id_pasien` int(11) NOT NULL,
  `keluhan` text NOT NULL,
  `diagnosa` text NOT NULL,
  `tanggal` date NOT NULL,
  `id_dokter` int(11) NOT NULL,
  `id_admin` int(11) NOT NULL,
  `status` enum('pendaftaran','pemeriksaan','tebus_obat','selesai') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tb_rekam_medis`
--

INSERT INTO `tb_rekam_medis` (`id_rekam`, `id_pasien`, `keluhan`, `diagnosa`, `tanggal`, `id_dokter`, `id_admin`, `status`) VALUES
(9, 5, 'Pusing, demam,', 'kurang vit C', '2021-03-08', 1, 1, 'selesai'),
(10, 6, 'sakit hati', 'test', '2021-03-08', 2, 9, 'selesai'),
(11, 1, 'serangan jantung', 'kurag minum', '2021-03-26', 1, 9, 'selesai'),
(13, 3, 'pusing', '', '2021-03-26', 5, 9, 'tebus_obat'),
(16, 1, 'gagal ginjal', 'kurang minum', '2021-03-08', 1, 9, 'tebus_obat'),
(17, 5, 'demam', 'a', '2021-03-26', 2, 9, 'tebus_obat'),
(18, 6, 'nyeri pinggang', ',jb', '2021-03-26', 1, 9, 'tebus_obat'),
(19, 1, 'gagal ginjal', 'kurang kasih sayang', '2021-03-08', 1, 9, 'tebus_obat'),
(20, 3, 'pusing', 'test', '2021-03-08', 5, 9, 'tebus_obat'),
(21, 7, 'sakit', 'hj', '2021-03-26', 1, 9, 'tebus_obat'),
(22, 1, 'gagal ginjal', 'sakit kepala', '2021-03-08', 1, 9, 'selesai'),
(23, 1, 'serangan jantung', 'kurang minum', '2021-03-26', 1, 9, 'tebus_obat'),
(24, 3, 'pusing', 'kurrang tidur', '2021-03-26', 5, 9, 'tebus_obat'),
(25, 6, 'serangan jantung', 'kurang minum', '2021-03-08', 1, 9, 'tebus_obat'),
(26, 1, 'gagal ginjal', 'a', '2021-03-08', 1, 9, 'tebus_obat'),
(27, 3, 'sakitkepala', 'hy', '2021-03-26', 1, 9, 'tebus_obat'),
(28, 5, 'pusing', 'a', '2021-03-26', 1, 9, 'tebus_obat'),
(29, 3, 'pilek', '', '2021-03-26', 1, 9, 'pemeriksaan'),
(30, 5, 'sakit', 'j', '2021-03-26', 1, 9, 'tebus_obat'),
(31, 9, 'Sakit Kepala', 'i', '2021-03-27', 1, 9, 'tebus_obat'),
(32, 10, 'Muntah Muntah', '', '2021-03-27', 1, 9, 'tebus_obat'),
(33, 9, 'Sakit Kepala', 'Kurang Tidur', '2021-03-27', 1, 9, 'selesai');

-- --------------------------------------------------------

--
-- Table structure for table `tb_resep`
--

CREATE TABLE `tb_resep` (
  `id_resep` int(11) NOT NULL,
  `id_rekam` int(11) NOT NULL,
  `id_obat` int(11) NOT NULL,
  `keterangan` text NOT NULL,
  `nama` varchar(150) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tb_resep`
--

INSERT INTO `tb_resep` (`id_resep`, `id_rekam`, `id_obat`, `keterangan`, `nama`) VALUES
(1, 0, 0, '', 'PARACETAMOL 250MG'),
(2, 0, 0, '', 'PARACETAMOL 500MG'),
(3, 0, 0, '', 'PARACETAMOL 250MG'),
(4, 0, 0, '', 'PARACETAMOL 250MG'),
(5, 0, 0, '', 'PARACETAMOL 250MG'),
(6, 0, 0, '', 'PARACETAMOL 250MG'),
(7, 0, 0, '', 'PARACETAMOL 250MG'),
(8, 0, 0, '', 'PARACETAMOL 250MG'),
(9, 0, 0, '', 'PARACETAMOL 250MG'),
(10, 0, 0, '', 'PARACETAMOL 250MG'),
(11, 6, 0, '', 'PARACETAMOL 250MG'),
(12, 6, 0, '', 'PARACETAMOL 250MG'),
(13, 6, 0, '', 'PARACETAMOL 500MG'),
(14, 6, 0, '', 'PARACETAMOL 250MG'),
(15, 6, 0, '', 'PARACETAMOL 500MG'),
(16, 6, 0, '', 'PARACETAMOL 250MG'),
(17, 6, 0, '', 'PARACETAMOL 500MG'),
(18, 7, 0, '', 'PARACETAMOL 250MG'),
(19, 6, 0, '', 'PARACETAMOL 250MG'),
(20, 6, 0, '', 'PARACETAMOL 500MG'),
(21, 1, 0, '', 'PARACETAMOL 250MG'),
(22, 1, 0, '', 'PARACETAMOL 500MG'),
(23, 9, 0, '', 'PANADOL'),
(24, 9, 0, '', 'PARACETAMOL 250MG'),
(25, 10, 0, '', 'PARACETAMOL 250MG'),
(26, 16, 0, '', 'PARAMEX 1000MG'),
(27, 16, 0, '', 'PARACETAMOL 500MG'),
(28, 19, 0, '', 'PARACETAMOL 500MG'),
(29, 19, 0, '', 'PARACETAMOL 250MG'),
(30, 20, 0, '', 'PANADOL 50MG'),
(31, 20, 0, '', 'PARACETAMOL 250MG'),
(32, 22, 0, '', 'PARACETAMOL 250MG'),
(33, 23, 0, '', 'PARACETAMOL 500MG'),
(34, 25, 0, '', 'PARACETAMOL 500MG'),
(35, 24, 0, '', 'PARACETAMOL 250MG'),
(36, 26, 0, '', 'PANADOL 50MG'),
(37, 18, 0, '', 'PARACETAMOL 500MG'),
(38, 11, 0, '', 'PARACETAMOL 250MG'),
(39, 17, 0, '', 'PARACETAMOL 250MG'),
(40, 21, 0, '', 'PARACETAMOL 500MG'),
(41, 27, 0, '', 'PARACETAMOL 500MG'),
(42, 28, 0, '', 'PARACETAMOL 500MG'),
(43, 33, 0, '', 'PARACETAMOL 500MG'),
(44, 33, 0, '', 'AMOXILIN 500MG'),
(45, 31, 0, '', 'PARACETAMOL 250MG');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tb_admin`
--
ALTER TABLE `tb_admin`
  ADD PRIMARY KEY (`id_admin`);

--
-- Indexes for table `tb_dokter`
--
ALTER TABLE `tb_dokter`
  ADD PRIMARY KEY (`id_dokter`);

--
-- Indexes for table `tb_obat`
--
ALTER TABLE `tb_obat`
  ADD PRIMARY KEY (`id_obat`);

--
-- Indexes for table `tb_pasien`
--
ALTER TABLE `tb_pasien`
  ADD PRIMARY KEY (`id_pasien`);

--
-- Indexes for table `tb_rekam_medis`
--
ALTER TABLE `tb_rekam_medis`
  ADD PRIMARY KEY (`id_rekam`);

--
-- Indexes for table `tb_resep`
--
ALTER TABLE `tb_resep`
  ADD PRIMARY KEY (`id_resep`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tb_admin`
--
ALTER TABLE `tb_admin`
  MODIFY `id_admin` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT for table `tb_dokter`
--
ALTER TABLE `tb_dokter`
  MODIFY `id_dokter` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `tb_obat`
--
ALTER TABLE `tb_obat`
  MODIFY `id_obat` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `tb_pasien`
--
ALTER TABLE `tb_pasien`
  MODIFY `id_pasien` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `tb_rekam_medis`
--
ALTER TABLE `tb_rekam_medis`
  MODIFY `id_rekam` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=34;

--
-- AUTO_INCREMENT for table `tb_resep`
--
ALTER TABLE `tb_resep`
  MODIFY `id_resep` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=46;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
