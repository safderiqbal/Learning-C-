Learning C#
===========

Repo to hold any test code used while getting to grips with C#
This was previously hosted on bitbucket as a mercurial repo, but I've migrated it over (manually, it seemed to take too long for such a small number of files to use a tool).

- HelloWorld: A basic application that does some verification over the text input and ensures it gets a persons name, with or without a middle name.

- LearningWindows: Another basic application that will launch a window, cleanly exit and also display a pop-up.

- Distribution: Project to package and generate .exe/.msi files for the other projects

## Temporary Paste of the .git/config:
	[core]
		repositoryformatversion = 0
		filemode = false
		bare = false
		logallrefupdates = true
		symlinks = false
		ignorecase = true
		hideDotFiles = dotGitOnly
	[remote "origin"]
		fetch = +refs/heads/*:refs/remotes/origin/*
		url = https://github.com/safder-iqbal/Learning-C-.git
		#url = https://safder_iqbal@bitbucket.org/safder_iqbal/learning-c.git
	[branch "master"]
		remote = origin
		merge = refs/heads/master
	[branch "Home"]
		remote = origin
		merge = refs/heads/Home