# LittleBit Game Library
Software to manage metadata about games.

# How does it work?
Each game is stored using user-editable YAML files, and by default the files are stored in \[Windows Documents folder\]/LittleBitGameLibrary/games.

Each game has 5 variables: `name`, `developer`, `description`, `imagepath`, and `genre`.
```yaml
name: # the first three are self-explanatory
developer: # ^
description: # ^
imagepath: # the filesystem path or web URL to the image you want to use for the game, such as an icon or box art
genre: # again, self explanatory, this can be just one genre (like "RPG") or multiple (like "Shooter, Battle Royale")
```

# Can I install this?
Yes, it's on my website: https://littlebitstudios.com/software/gamelibrary
