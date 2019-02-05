#!/usr/bin/env bash

set -e
set -x
mkdir -p "/Library/Application Support/Unity/Unity_v2018.x.ulf"
chmod a+x "/Library/Application Support/Unity/Unity_v2018.x.ulf"
set +x
echo 'Writing $UNITY_LICENSE_CONTENT to license file /Library/Application Support/Unity/Unity_v2018.x.ulf'
echo "$UNITY_LICENSE_CONTENT" | tr -d '\r' > /Library/Application Support/Unity/Unity_v2018.x.ulf
