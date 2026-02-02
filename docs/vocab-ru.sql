CREATE TABLE `vocab_ru` (
  `azString` varchar(256) NOT NULL,
  `word` varchar(64) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

ALTER TABLE `vocab_ru`
    ADD PRIMARY KEY (`azString`);
