#!/bin/bash

cat > $1 <<EOF
# API Reference
osu!framework API reference doumentation

Welcome to the **osu!framework** reference documentation!

This area should cover most details on each class and method in the API that you can use in your projects.

Do note that the contents are generated (with docfx) so there may be missing or outdated informations

Also check out the [wiki](../osu-framework.wiki/Home.md) to get a quick start!


</br>

---
</br>

> Last updated:
> <b><time>$(date +"%Y-%m-%d %H:%M")</time></b>
>
> Last commit reference build:
[${2:0:5}](https://github.com/BashhScriptKid/unofficial.osuframework.web/commit/$2)
<!-- can be either a commit link from origin or upstream -->
EOF
echo "Written to $1."