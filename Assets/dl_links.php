<?php


$links = file('missing.txt');

foreach ($links as $link) {
  $link = trim($link);

  // match just the name 
  $filename = basename($link);

  if (!file_exists("other/$filename")) {
    // download to folder
    echo "downloading $filename\n";
    file_put_contents("other/$filename", file_get_contents($link));

    sleep(2);
  }
}