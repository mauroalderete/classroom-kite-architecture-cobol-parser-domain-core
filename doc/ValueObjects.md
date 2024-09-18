
```mermaid
---
title: ValueObjects example
---
classDiagram
    AnyFile <-- LocalFileLocation
    AnyFile <-- FtpFileLocation

    FtpFileLocation <-- Hostname
    FtpFileLocation <-- FolderLocation
    FtpFileLocation <-- LocalFileLocation

    LocalFileLocation <-- Filename
    LocalFileLocation <-- FolderLocation

```