## Git---------切换分支&&Merge

#### git 分支查看与切换

> 1. git  branch -a # 查看所有的分支
> 2. git branch # 查看当前的分支
> 3. git  checkout branch name # 切换分支

#### git 查看分支信息

> 1. git log --decorate --online # 一行显示
> 2. git log --decorate --online --graph -all #图形显示

#### git创建分支并且切换到分支

> 1. git checkout -b branchname #创建分支并切换



#### 开发分支上的代码到达上限的标准后,侯冰到master分支上.

> 1. git checkout dev
> 2. git pull
> 3. git checkout master
> 4. git merge dev
> 5. git push -u origin master



#### 当master代码改动了,需要更新开发分支上的代码

> 1. git checkout master
> 2. git pull
> 3. git checkout dev
> 4. git merge master
> 5. git push -u origin dev