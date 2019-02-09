#! /bin/sh
BASE_URL=https://netstorage.unity3d.com/unity/
HASH=393bae82dbb8
VERSION=2018.3.3f1
download() {
  file=$1
  url="$BASE_URL/$HASH/$package"

  echo "Downloading from $url: "
  curl -o `basename "$package"` "$url"
}

install() {
  package=$1
  download "$package"

  echo "Installing "`basename "$package"`
  sudo installer -dumplog -package `basename "$package"` -target /
}

# See $BASE_URL/$HASH/unity-$VERSION-$PLATFORM.ini for complete list
# of available packages, where PLATFORM is `osx` or `win`

install "Unity-$VERSION.pkg"
#install "Windows64EditorInstaller/UnitySetup64-$VERSION.pkg"
install "MacEditorInstaller/Unity-$VERSION.pkg"
#install "UnitySetup-Linux-Support-for-Editor-$VERSION.pkg"

# https://netstorage.unity3d.com/unity/393bae82dbb8/Windows64EditorInstaller/UnitySetup64-2018.3.3f1.exe?_ga=2.143539637.1834526946.1548748994-1956150118.1547220807
# https://netstorage.unity3d.com/unity/393bae82dbb8/MacEditorInstaller/Unity-2018.3.3f1.pkg?_ga=2.151985465.1834526946.1548748994-1956150118.1547220807