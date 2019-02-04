#! /bin/sh

project="break-it"

# echo "Attempting to build $project for Windows"
# /Applications/Unity/Unity.app/Contents/MacOS/Unity 
#   -batchmode 
#   -nographics 
#   -silent-crashes 
#   -logFile $(pwd)/unity.log 
#   -projectPath $(pwd) 
#   -buildWindowsPlayer "$(pwd)/Build/windows/$project.exe" 
#   -quit

echo "Attempting to build $project for OS X"
/Applications/Unity/Unity.app/Contents/MacOS/Unity 
  -username "lpdam2019@gmail.com"
  -password "f6zJDPfpP7cQZU"
  -batchmode 
  -nographics
  -logFile "$(pwd)/Logs/unity.log" 
  -projectPath "$(pwd)/" 
  -executeMethod BuildScript.OSX 
  -quit

# echo "Attempting to build $project for Linux"
# /Applications/Unity/Unity.app/Contents/MacOS/Unity 
#   -batchmode 
#   -nographics 
#   -silent-crashes 
#   -logFile $(pwd)/unity.log 
#   -projectPath $(pwd) 
#   -buildLinuxUniversalPlayer "$(pwd)/Build/linux/$project.exe" 
#   -quit

echo 'Logs from build'
cat $(pwd)/Logs/unity.log
