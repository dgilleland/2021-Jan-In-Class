# Using git

These are my notes on using the git version control system.

You can toggle the terminal in VS Code by pressing `ctrl` + backtick.

```
[ctrl] + `
```

## Command Line

- `git clone [repo]` - where the `[repo]` is the URL of the remote repository. This will create a local copy of a remote repository. You only need to do this once per repository.
- `git status` - Will show you the current status of the repository, with any information on changes that are staged or unstaged.
- `git add .` - This command will "stage" changed/new files for commits
- `git commit -m "Short Description"` - This command will save a "snapshot" of the changes you have staged. It effectivly adds to the commit history of your repository
- `git pull` - This command will grab changes/commits from the **remote** (in this case, from GitHub.com) and bring them down onto your computer
- `git push` - This command will take the local commits you have done and place them in your **remote repository** (on GitHub.com)

You use the `pull` and `push` commands in git to ***synchronize*** your **local** and **remote** repositories. The local repo is the one on your computer. The remote repo is the one in the cloud.
