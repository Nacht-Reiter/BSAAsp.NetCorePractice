﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace BSAAsp.NetCorePractice
{
public class Queries
    {
        private DataGiver Data;

        public Queries(DataGiver dataGiver)
        {
            Data = dataGiver;
        }

        public int GetMaxUserId()
        {
            return Data.Users.Max(u => u.Id);
        }

        public int GetMaxPostId()
        {
            return Data.Users.SelectMany(u => u.Posts).Max(p => p.Id);
        }

        public IEnumerable<(Post, int)> CountCommentsUnderPosts(int userId)//1 required query
        {
            if(Data.Users.Select(u => u.Id).Contains(userId))
            {
                return Data.Users.Where(u => u.Id == userId).SelectMany(u => u.Posts)
                    .Select(p => (Post: p, CommentsAmount: p.Comments.Count()));
            }
            throw new ArgumentException("Wrong User id");
        }

        public IEnumerable<Comment> GetShortCommentsUnderPosts(int userId)//2 required query
        {
            if (Data.Users.Select(u => u.Id).Contains(userId))
            {
                return Data.Users.Where(u => u.Id == userId).SelectMany(u => u.Posts)
                    .SelectMany(p => p.Comments).Where(c => c.Body.Count() < 50);
            }
            throw new ArgumentException("Wrong User id");
        }

        public IEnumerable<(int, string)> GetCompleteTodoes(int userId)//3 required query
        {
            if (Data.Users.Select(u => u.Id).Contains(userId))
            {
                return Data.Users.Where(u => u.Id == userId).SelectMany(u => u.Todoes)
                    .Where(t => t.IsComplete == true).Select(t => (t.Id, t.Name));
            }
            throw new ArgumentException("Wrong User id");
        }

        public IEnumerable<User> GetSortedUsers()//4 required query
        {
            return Data.Users.OrderBy(u => u.Name).Select(
                u => new User
                {
                    Todoes = u.Todoes.OrderByDescending(t => t.Name.Count()),
                    Posts = u.Posts,
                    Id = u.Id,
                    Name = u.Name,
                    CreatedAt = u.CreatedAt,
                    Avatar = u.Avatar,
                    Email = u.Email
                });
        }

        public (User, Post, int, int, Post, Post) GetUserInfo(int userId)//5 required query
        {
            if (Data.Users.Select(u => u.Id).Contains(userId))
            {
                return Data.Users.Where(u => u.Id == userId)
                    .Select(u => (User: u,
                        LastPost: u.Posts.OrderByDescending(p => p.CreatedAt).First(),
                        LastPostCommentsAmount: u.Posts.OrderByDescending(p => p.CreatedAt).First().Comments.Count(),
                        UncompleteTodoesAmount: u.Todoes.Where(t => t.IsComplete == false).Count(),
                        ComentedPost: u.Posts.OrderByDescending(p => p.Comments.Where(c => c.Body.Count() > 80).Count()).FirstOrDefault(),
                        LikedPost: u.Posts.OrderByDescending(p => p.Likes).FirstOrDefault()
                    )).First();
            }
            throw new ArgumentException("Wrong User id");
        }

        public (Post, Comment, Comment, int) GetPostInfo(int postId)//6 required query
        {
            if(Data.Users.SelectMany(u => u.Posts).Select(p => p.Id).Contains(postId))
            {
                return Data.Users.SelectMany(u => u.Posts).Where(p => p.Id == postId)
                    .Select(p => (Post: p,
                        LongestComment: p.Comments.OrderByDescending(c => c.Body.Count()).FirstOrDefault(),
                        LikedComment: p.Comments.OrderByDescending(c => c.Likes).FirstOrDefault(),
                        TrashCommentsAmount: p.Comments.Where(c => c.Likes == 0 || c.Body.Count() < 80).Count()
                    )).First();
            }
            throw new ArgumentException("Wrong User id");
        }
    }
}
