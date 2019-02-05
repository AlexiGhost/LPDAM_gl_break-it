#!/usr/bin/env bash

set +x
echo 'Writing $UNITY_LICENSE_CONTENT to license file /Library/Application Support/Unity/Unity_lic.ulf'
echo "$UNITY_LICENSE_CONTENT" | tr -d '\r' > /Library/Application Support/Unity/Unity_lic.ulf
