7z e %userprofile%/desktop/schedulingsystemdatabasebackup.7z -aoa -poiewjmfc9843myv92438jmy5mt25m4212mt54m94t403cre97rcny3ryc43897tnv3409pwoioplqoisjihdnvibldkjajj99izxixiofgusdo9wertoieytweioru4598n43o85548384945f09k5f94kk23i02304k32094m320ednoi23nfr90m230ed2n39rn8334983728497239478309509235809384420m40239k4d0m238094j8m23
mysql -u root -proot -e create database if not exists scheduling
mysql -u root -proot -e use scheduling
mysql -u root -proot use scheduling <scheduling.sql
del scheduling.sql -q