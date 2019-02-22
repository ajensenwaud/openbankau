REM java -Dfile.encoding=UTF-8 -jar swagger-codegen-cli.jar generate -i "https://consumerdatastandardsaustralia.github.io/standards/includes/swagger/cds_full.json" -l aspnetcore -c config.json
java -Dfile.encoding=UTF-8 -jar "C:\Users\45953\dev\swagger-codegen\modules\swagger-codegen-cli\target\swagger-codegen-cli.jar" generate -i "cds_full.json" -l aspnetcore -c config.json
REM move /Y src\OpenBanking\*.* .
REM move /Y src\OpenBanking\Controllers .
REM move /Y src\OpenBanking\Controllers\*.* .\Controllers
REM move /Y src\OpenBanking\Attributes .
REM move /Y src\OpenBanking\Attributes\*.* .\Attributes
REM move /Y src\OpenBanking\Filters .
REM move /Y src\OpenBanking\Filters\*.* .\Filters
REM move /Y src\OpenBanking\Models .\
REM move /Y src\OpenBanking\Models\*.* .\Models
REM move /Y src\OpenBanking\Properties\*.* .\Properties
REM move /Y src\OpenBanking\wwwroot\*.* .\wwwroot