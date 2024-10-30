-- Important create login in master
-- use master
create login appadmin with password = 'secret!(280)'

-- Important switch to recordkeeperdb
create user appadmin_user from login appadmin