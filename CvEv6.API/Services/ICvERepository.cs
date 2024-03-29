﻿using CvEv6.API.Entities;
using CvEv6.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CvEv6.API.Services
{
    public interface ICvERepository
    {
        bool domainEntityExists(int domainId);
        IEnumerable<Domain> GetDomainEntities();
        Domain GetDomainEntity(int domainId, bool includeDocuments);
        IEnumerable<Document> GetDocumentsForDomainEntity(int domainId);
        Document GetDocumentForDomainEntity(int domainId, int documentId);
        void AddDocumentForDomainEntity(int domainId, Document document);
        void DeleteDocumentForDomainEntity(Document document);
        object GetMainBodyEntity(int id);
        bool MainBodyExists(int id);
        IEnumerable<MainBody> GetMainBodyEntities();
        bool Save();
        List<Title> GetTitles();
        Title GetTitle(int titleId);
        void AddDDomainEntity(Domain domain);
        bool domainEntityExists(string name);
        bool TitleEntityExists(string name);
        bool TitleEntityExists(int id);
        bool MainBodyExists(string name);
        void AddTitleEntity(Title finalTitle);
        void DeleteTitleEntity(Title title);
        void DeleteDomainEntity(Domain domainEntity);
        void AddMainBodyEntity(MainBody mainbody);
    }
}
