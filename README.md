# TimestampsToCue
Convert timestamps from youtube-like descriptions into CUE format fore easy manipulation.

# Usage
User has a list of songs with timestamps in this format (from https://www.youtube.com/watch?v=A8qMyBWZNw0)

```
14:57 Gilded Vale - Pillars of Eternity
18:13 The City Gates - The Elder Scrolls V: Skyrim
22:00 Spikeroog - The Witcher III: Wild Hunt
```

This library/app allows to convert it into a CUE format:

```
TITLE "Peaceful Music"
FILE "Peaceful Music.mp3"
  TRACK 01 AUDIO
    TITLE "Gilded Vale - Pillars of Eternity"
    INDEX 01 14:57:00
  TRACK 02 AUDIO
    TITLE "The City Gates - The Elder Scrolls V: Skyrim"
    INDEX 01 18:13:00
  TRACK 03 AUDIO
    TITLE "Spikeroog - The Witcher III: Wild Hunt"
    INDEX 01 22:00:00
```

Note: the timestamp does not has to be at the beginning, it works as well with timestamps in different places (the only limitation is 1 timestamp per line)

```
Gilded Vale - Pillars of 14:57  Eternity
The City 18:13 Gates - The Elder Scrolls V: Skyrim
Spikeroog - The Witcher III: Wild Hunt 22:00
```

```
TITLE "Peaceful Music"
FILE "Peaceful Music.mp3"
  TRACK 01 AUDIO
    TITLE "Eternity"
    INDEX 01 14:57:00
  TRACK 02 AUDIO
    TITLE "Gates - The Elder Scrolls V: Skyrim"
    INDEX 01 18:13:00
  TRACK 03 AUDIO
    TITLE "Spikeroog - The Witcher III: Wild Hunt"
    INDEX 01 22:00:00
```
